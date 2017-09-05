using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryPopulate
    {
        public static void populate()
        {
            QueryBooks.searchBook("","","","","","","","","");
            QueryStudent.getStudents("","","","","");
            QueryBorrow.getBooks();
            QueryReturn.getBooks("", "");
        }
    }
}
