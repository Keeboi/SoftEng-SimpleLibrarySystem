using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    class QueryAccounts
    {
        public static int level = 0;

        public static Dictionary<string, string> loginUser(string user, string pass)
        {
            try
            {
                SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
                sql.openConnection();
                string query = String.Format("select username, password,type_id  from tblaccounts where username='{0}' and password='{1}'", user, pass);
                

                List<string> woh = new List<string>();

                foreach (System.Data.DataRow x in sql.getData(query).Rows)
                {
                    woh = x.ItemArray.Select(a => a.ToString()).ToList();
                }
                string username = woh.First();
                string password = woh.Skip(1).First();
                level = int.Parse(woh.Last());
                Console.WriteLine(password);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add(user, pass);
                return dic;
            }
            catch
            {
                return null;
            }
        }
    }
}
