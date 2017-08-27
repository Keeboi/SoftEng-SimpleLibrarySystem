using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// Interaction logic for UserControl_Return.xaml
    /// </summary>
    public partial class UserControl_Return : UserControl
    {
        public UserControl_Return()
        {
            InitializeComponent();
            popTable();
        }
        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = "select tblbooks.book_id as \"Book ID\", tblbooks.title as \"Book Title\", " +
                "concat(tblstudents.student_fname, \" \", tblstudents.student_lname) as \"Student\" , " +
                "tblstudents.student_id as \"Student ID\", " +
                "date_borrowed as \"Date Borrowed\", " +
                "date_fined as \"Date Fined\" " +
                " from tblborrowedbooks " +
                " join tblbooks on " +
                " tblborrowedbooks.book_id = tblbooks.book_id " +
                " join tblstudents on " +
                " tblborrowedbooks.student_id = tblstudents.student_id" +
                " where date_returned is null;";

            if (sql.getData(query) != null) // table is a DataTable
            {
                foreach (System.Data.DataColumn col in sql.getData(query).Columns)
                {
                    dg.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("{0}", col.ColumnName))
                      });
                }

                dg.DataContext = sql.getData(query);
            }
            sql.closeConnection();
        }
    }
}
