using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryBorrow
    {
        public static System.Data.DataTable getBooks()
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = "select tblbooks.book_id as \"Book ID\", tblbooks.title as \"Book Title\", " +
                "concat(tblstudents.student_fname, \" \", tblstudents.student_lname) as \"Student\" , " +
                "tblstudents.student_id as \"Student ID\", " +
                "date_borrowed as \"Date Borrowed\", " +
                "date_fined as \"Date to be Fined\" " +
                " from tblborrowedbooks " +
                " join tblbooks on " +
                " tblborrowedbooks.book_id = tblbooks.book_id " +
                " join tblstudents on " +
                " tblborrowedbooks.student_id = tblstudents.student_id" +
                " where date_returned is null" +
                " order by tblbooks.book_id asc;";
            return sql.getData(query);
        }
        public static string[] getInfo(string bookID, string studentID)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = String.Format("select title, concat(Author_fname, \" \", Author_lname), "+
                "year, quantity, comments from tblbooks "+
                "inner join tblauthors on "+
                "tblbooks.author_id = tblauthors.author_id " +
                "where book_id like '{0}%'", bookID);
            System.Data.DataTable dt = sql.getData(query);

            string[] output;
            if (dt.Rows.Count != 0)
            {
                output = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                string[] output2 = { };
                query = String.Format("select concat(student_fname, \" \", student_lname), " +
                    "grade, student_section from tblstudents " +
                    "inner join tblgrades on " +
                    "tblstudents.grade_id = tblgrades.grade_id " +
                    "where student_id like '{0}%'", studentID);
                dt = sql.getData(query);
                if (dt.Rows.Count != 0)
                {
                    output2 = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                    return output.Concat(output2).ToArray();
                }
            }
            return null; //new string[] { "eh" };
        }
        public static void addBorrowedBook(string bookid, string studentid)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = String.Format("insert into tblborrowedbooks (" +
                "book_id, student_id, date_borrowed, date_fined) " +
                "values('{0}', '{1}', now(), " +
                "DATE_ADD(now(), interval 1 week));", bookid, studentid);
            sql.addData(query);
            sql.closeConnection();
        }
    }
}
