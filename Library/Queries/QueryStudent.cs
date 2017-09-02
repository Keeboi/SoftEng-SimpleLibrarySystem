using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Queries
{
    class QueryStudent
    {
        public static System.Data.DataTable getStudents(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = String.Format("select student_id as \"Student ID\", " +
                "student_fname as \"Student First Name\", " +
                "student_lname as \"Student Last Name\", " +
                "tblgrades.student_section as Section from tblstudents " +
                "join tblgrades on tblstudents.grade_id = tblgrades.grade_id " +
                "where student_id like '{0}%' and " +
                "student_fname like '{1}%' and " +
                "student_lname like '{2}%' and " +
                "tblgrades.student_section like '{3}%' " +
                "order by student_id asc;",
                inputs[0], inputs[1], inputs[2], inputs[3]);
            return sql.getData(query);
        }
        public static void addStudent(params string[] inputs)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = String.Format("insert into tblstudents(" +
                "student_id, student_Fname, student_lname, grade_id) " +
                "values('{0}', '{1}', '{2}', '{3}')",
                inputs[0], inputs[1], inputs[2], inputs[3]);
            sql.addData(query);
            sql.closeConnection();
        }
        public static List<string> getSection()
        {
            string query = "select student_section from tblgrades";
            return getList(query);
        }
        private static List<string> getList(string query)
        {
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            System.Data.DataTable dt = sql.getData(query);
            if (dt.Rows.Count != 0)
            {
                List<string> woh = new List<string>();
                foreach (System.Data.DataRow x in dt.Rows)
                    woh.Add(string.Join(" ", x.ItemArray.Select(y => y.ToString()).ToList()));
                return woh;
            }
            return new List<string>();
        }
    }
}
