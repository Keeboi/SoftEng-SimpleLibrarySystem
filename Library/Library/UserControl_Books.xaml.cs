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
    /// Interaction logic for UserControl_Books.xaml
    /// </summary>
    public partial class UserControl_Books : UserControl
    {
        public UserControl_Books()
        {
            InitializeComponent();
            popTable();
        }

        private void buttonSearchAdd_Click(object sender, RoutedEventArgs e)
        {
            //if book does not exist in database {
            if (MessageBox.Show("Book does not exist in database.\nWould you like to add one now?","Not Found!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Window_AddBook addBook = new Window_AddBook();
                addBook.Show();
            }
            // }
        }
        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();
            
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = "select " +
                " tblbooks.book_id as \"Book ID\"," +
                "title as Title, " +
                "concat(tblauthors.author_fname, \" \", tblauthors.author_lname) as Author," +
                "year as Year," +
                "no_of_pages as \"No. of Pages\"," +
                "tblcategories.category as Category," +
                "tblbooksection.section as Section," +
                "quantity as Quantity," +
                "available_books as Available," +
                "comments as Comments " +
                "from tblbooks " +
                "inner join " +
                "tblauthors on " +
                "tblbooks.author_ID = tblauthors.author_ID " +
                "inner " +
                "join " +
                "tblcategories on " +
                "tblbooks.category_id = tblcategories.category_id " +
                "inner " +
                "join " +
                "tblbooksection on " +
                "tblbooks.section_id = tblbooksection.section_id " +
                "where tblbooks.book_id like '" + textBookID.Text + "%' and " +
                " title like '" + textTitle.Text + "%' and " +
                " (tblauthors.author_fname like '" + comboAuthor.Text + "%' or " +
                " tblauthors.author_lname like '" + comboAuthor.Text + "%') and " +
                " year like '" + textYear.Text + "%' and " +
                " quantity like '" + textQuantity.Text + "%' and " +
                " no_of_pages like '" + textPages.Text + "%' and " +
                " tblcategories.category like '" + comboCategory.Text + "%' and " +
                " tblbooksection.section like '" + comboSection.Text + "%' and " +
                " comments like '" + textComments.Text + "%'";
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

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (System.Data.DataRowView x in e.AddedItems)
            {
                textBookID.Text = x.Row[0].ToString();
                textTitle.Text = x.Row[1].ToString();
                comboAuthor.Text = x.Row[2].ToString();
                textYear.Text = x.Row[3].ToString();
                textQuantity.Text = x.Row[7].ToString();
                textPages.Text = x.Row[4].ToString();
                comboCategory.Text = x.Row[5].ToString();
                comboSection.Text = x.Row[6].ToString();
                textComments.Text = x.Row[9].ToString();
            }
        }
    }
}
