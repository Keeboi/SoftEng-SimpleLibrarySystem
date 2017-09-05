using System;
using System.Collections.Generic;
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

            /*DataTable dt = Queries.QueryBorrow.getBooks();

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
            List<Models.BorrowedItem> borrowedItem = Queries.QueryBorrow.getBooks();
            dg.ItemsSource = borrowedItem;

        }

        private void buttonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                string studentID = textStudentID.Text;
                string bookID = textBookID.Text;
                //string[] info = Queries.QueryBorrow.getInfo(bookID, studentID);
                Models.Book book = Queries.QueryBooks.book.Find(x => x.BookID + "" == bookID);
                Models.Student student = Queries.QueryStudent.student.Find(x => x.StudentId + "" == studentID);

                textTitle.Text = book.Title;
                comboAuthor.Text = book.Author;
                textYear.Text = book.Year+"";
                textQuantity.Text = book.Quantity + "";
                textComments.Text = book.Comments;
                textStudentName.Text = student.FirstName+" "+student.LastName;
                textStudentLevel.Text = student.Grade+"";
                textStudentSection.Text = student.Section;
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
                if (!Queries.QueryBorrow.addBorrowedBook(textBookID.Text, textStudentID.Text))
                    MessageBox.Show("Student has fines, please pay them before borrowing.", "Fines", MessageBoxButton.OK);
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
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if ((string)e.Column.Header == "DateReturned")
                e.Cancel = true;
            Headers.DataHeaders.generateColumn(e);

        }
    }
}
