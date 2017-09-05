using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            /*DataTable dt = Queries.QueryReturn.getBooks("","");

            if (dt != null) // table is a DataTable
            {
                foreach (DataColumn col in dt.Columns)
                {
                    dg.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("{0}", col.ColumnName))
                      });
                }
                dg.DataContext = dt;
            }*/
            List<Models.BorrowedItem> borrowedItem = Queries.QueryReturn.getBooks("","");
            dg.ItemsSource = borrowedItem;
        }

        private void buttonSearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dg.Columns.Clear();
            dg.Items.Refresh();

            string[] text =
            {
                textBookID.Text,
                textStudentID.Text
            };
            /*DataTable dt = Queries.QueryReturn.getBooks(text);

            if (dt != null) // table is a DataTable
            {
                foreach (DataColumn col in dt.Columns)
                {
                    dg.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("{0}", col.ColumnName))
                      });
                }
                dg.DataContext = dt;
            }*/
            List<Models.BorrowedItem> borrowedItem = Queries.QueryReturn.getBooks(text);
            dg.ItemsSource = borrowedItem;
        }

        private void buttonReturn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                Queries.QueryReturn.returnBook(textStudentID.Text, textBookID.Text);
                clearField();
                popTable();
            }
            else
                MessageBox.Show("Please fill out all fields.", "Empty Data", MessageBoxButton.OK);
        }

        public void clearField()
        {
            textStudentID.Clear();
            textBookID.Clear();
        }

        private void buttonClear_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            clearField();
            popTable();
        }
        private bool isEmpty()
        {
            return textStudentID.Text == "" || textBookID.Text == "";
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            System.Console.WriteLine(e.Column.Header);
            if ((string)e.Column.Header == "DateReturned")
                e.Cancel = true;
            Headers.DataHeaders.generateColumn(e);

        }
    }
}
