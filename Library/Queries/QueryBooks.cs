using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryBooks
    {
        public static List<Models.Book> book;

        public static List<Models.Book> searchBook(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            #region Book Query
            string query = String.Format("select " +
                " tblbooks.book_id as \"BookID\"," +
                "title as Title, " +
                "concat(tblauthors.author_fname, \" \", tblauthors.author_lname) as Author," +
                "year as Year," +
                "no_of_pages as \"Pages\"," +
                "tblcategories.category as Category," +
                "tblbooksection.section as Section," +
                "quantity as Quantity," +
                "available_books as Available," +
                "comments as Comments " +
                "from tblbooks " +
                "inner join tblauthors on " +
                "tblbooks.author_ID = tblauthors.author_ID " +
                "inner join tblcategories on " +
                "tblbooks.category_id = tblcategories.category_id " +
                "inner join tblbooksection on " +
                "tblbooks.section_id = tblbooksection.section_id " +
                "where tblbooks.book_id like '{0}%' and " +
                " title like '{1}%' and " +
                //" (tblauthors.author_fname like '{2}%' or " +
                //" tblauthors.author_lname like '{2}%') and " +
                //FIX AUTHOR SEARCHING!
                " year like '{3}%' and " +
                " quantity like '{4}%' and " +
                " no_of_pages like '{5}%' and " +
                " tblcategories.category like '{6}%' and " +
                " tblbooksection.section like '{7}%' and " +
                " comments like '{8}%'" +
                " order by book_id asc",
                inputs[0], inputs[1], inputs[2], inputs[3], inputs[4],
                inputs[5], inputs[6], inputs[7], inputs[8]);
            #endregion
            Console.WriteLine(query);
            System.Data.DataTable dt = sql.getData(query);
            List<Models.Book> books = Models.DataToList.TransformTableToList<Models.Book>(dt);
            book = books;
            return books;
        }
        public static void addBook(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            
            if (!checkAvailableAuthor(inputs[2]) && !int.TryParse(inputs[2], out int x))
            {
                inputs[2] = addAuthor(inputs[2])+"";
            }
            if (!checkAvailableCategory(inputs[7]) && !int.TryParse(inputs[7], out x))
            {
                inputs[7] = addCategory(inputs[7]) + "";
            }
            if (!checkAvailableSection(inputs[8]) && !int.TryParse(inputs[8], out x))
            {
                inputs[8] = addSection(inputs[8]) + "";
            }

            string query = String.Format("insert into tblBooks(" +
            "book_id, title, author_id, year, quantity, available_books" +
            ", no_of_pages, category_id, section_id, comments) " +
            "values( {0}, '{1}', {2}, {3}, {4}, {5}, {6}, {7}, {8}, '{9}' )",
            inputs[0], inputs[1], inputs[2], inputs[3], inputs[4], 
            inputs[5], inputs[6], inputs[7], inputs[8], inputs[9]);
            sql.addData(query);
            sql.closeConnection();
        }
        private static long addAuthor(string name)
        {
            var split = name.Split(' ');
            string query = String.Format("insert into tblauthors( author_fname, author_lname )" +
                "values( '{0}', '{1}')", split.First(), string.Join(" ", split.Skip(1).ToArray()));
            Console.WriteLine(query);
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            return sql.addData(query);
        }
        private static long addSection(string section)
        {
            string query = String.Format("insert into tblbooksection( section )" +
                "values( '{0}')", section);
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            return sql.addData(query);
        }
        private static long addCategory(string category)
        {
            string query = String.Format("insert into tblcategories( category )" +
                "values( '{0}')", category);
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            return sql.addData(query);
        }
        public static List<string> getAuthors()
        {
            /*string query = "select concat(author_fname, \" \", author_lname) from tblauthors";
            return getList(query);*/
            return book.Select(A => A.Author).Distinct().ToList();
        }
        public static List<string> getCategories()
        {
            /*string query = "select category from tblcategories";
            return getList(query);*/
            return book.Select(C => C.Category).Distinct().ToList();
        }
        public static List<string> getSections()
        {
            /*string query = "select section from tblbooksection";
            return getList(query);*/
            return book.Select(S => S.Section).Distinct().ToList();
        }

        /*private static List<string> getList(string query)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            System.Data.DataTable dt = sql.getData(query);
            if (dt.Rows.Count != 0)
            {
                List<string> woh = new List<string>();
                foreach(System.Data.DataRow x in dt.Rows)
                    woh.Add(string.Join(" ",x.ItemArray.Select(y => y.ToString()).ToList()));
                return woh;
            }
            return new List<string>();
        }*/
        private static bool checkAvailableAuthor(string authorName)
        {
            foreach (string s in getAuthors())
                if (s == authorName)
                    return true;
            return false;
        }
        private static bool checkAvailableSection(string section)
        {
            foreach (string s in getSections())
                if (s == section)
                    return true;
            return false;
        }
        private static bool checkAvailableCategory(string category)
        {
            foreach (string s in getCategories())
                if (s == category)
                    return true;
            return false;
        }
    }
}
