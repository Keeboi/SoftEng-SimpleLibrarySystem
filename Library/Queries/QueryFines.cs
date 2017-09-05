using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryFines
    {
        public static void increaseFines(List<Models.BorrowedItem> bi)
        {

            foreach(Models.BorrowedItem item in bi)
            {
                if (item.DateReturned == new DateTime())
                {
                    int fine = Date.DateCheck.compareDates(item.DateToBeFined) ? Date.DateCheck.getAmount(item.DateToBeFined) : 0;
                    item.Fine = fine;

                    SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
                    sql.openConnection();
                    string query = String.Format("update tblborrowedbooks set " +
                    "fines = {0} where student_id = '{1}' AND " +
                    "book_id = '{2}' AND date_returned is null", item.Fine, item.Student.StudentId, item.Book.BookID);
                    sql.addData(query);
                    sql.closeConnection();
                    Console.WriteLine(query);
                }
            }
        }
    }
}
