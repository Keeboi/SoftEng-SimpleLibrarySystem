using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryReturn
    {
        public static List<Models.BorrowedItem> returned;

        public static List<Models.BorrowedItem> getBooks(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = String.Format("select tblbooks.book_id as \"BookId\", tblbooks.title as \"Book Title\", " +
                "concat(tblstudents.student_fname, \" \", tblstudents.student_lname) as \"Student\" , " +
                "tblstudents.student_id as \"StudentId\", " +
                "date_borrowed as \"DateBorrowed\", " +
                "date_fined as \"DateToBeFined\" " +
                " from tblborrowedbooks " +
                " join tblbooks on " +
                " tblborrowedbooks.book_id = tblbooks.book_id " +
                " join tblstudents on " +
                " tblborrowedbooks.student_id = tblstudents.student_id" +
                " where date_returned is null and " +
                " tblborrowedbooks.book_id like '{0}%' and " +
                " tblstudents.student_id like '{1}%'" +
                " order by tblbooks.book_id asc;", inputs[0], inputs[1]);
            System.Data.DataTable dt = sql.getData(query);
            List<Models.BorrowedItem> borrowedItems = Models.DataToList.TransformTableToList<Models.BorrowedItem>(dt);
            returned = borrowedItems;
            QueryFines.increaseFines(returned);
            return borrowedItems;
        }
        public static void returnBook(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = string.Format("update tblborrowedbooks set " +
                "date_returned = now() where student_id = '{0}' AND " +
                "book_id = '{1}' AND date_returned is null", inputs[0], inputs[1]);
            sql.addData(query);
            sql.closeConnection();
        }
    }
}
