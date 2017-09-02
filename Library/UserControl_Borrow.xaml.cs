using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Library
{
    /// <summary>
    /// Interaction logic for UserControl_Borrow.xaml
    /// </summary>
    public partial class UserControl_Borrow : UserControl
    {
        public UserControl_Borrow()
        {
            InitializeComponent();
            popTable();
        }
        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();

            DataTable dt = Queries.QueryBorrow.getBooks();

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
            }
            
        }

        private void buttonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                string studentID = textStudentID.Text;
                string bookID = textBookID.Text;
                string[] info = Queries.QueryBorrow.getInfo(bookID, studentID);
                if (info != null)
                {
                    textTitle.Text = info[0];
                    comboAuthor.Text = info[1];
                    textYear.Text = info[2];
                    textQuantity.Text = info[3];
                    textComments.Text = info[4];
                    textStudentName.Text = info[5];
                    textStudentLevel.Text = info[6];
                    textStudentSection.Text = info[7];
                }
            }
            else
                MessageBox.Show("Please fill out all fields.", "Empty Data", MessageBoxButton.OK);
        }
        public void clearField()
        {
            textStudentID.Clear();
            textBookID.Clear();
            textTitle.Clear();
            comboAuthor.Text = "";
            textYear.Clear();
            textQuantity.Clear();
            textComments.Clear();
            textStudentName.Clear();
            textStudentLevel.Clear();
            textStudentSection.Clear();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            clearField();
            popTable();
        }

        private void buttonConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                Queries.QueryBorrow.addBorrowedBook(textBookID.Text, textStudentID.Text);
                popTable();
            }
            else
                MessageBox.Show("Please fill out all fields.", "Empty Data", MessageBoxButton.OK);
        }
        private bool isEmpty()
        {
            return textStudentID.Text == "" ||
                textBookID.Text == "";
        }
    }
}
