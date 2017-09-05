using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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
            populateComboBoxes();
        }
        private void populateAuthors()
        {
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            Queries.QueryBooks.getAuthors().ForEach(x =>
                list.Add(x));
            comboAuthor.ItemsSource = list;
        }
        private void populateCategories()
        {
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            Queries.QueryBooks.getCategories().ForEach(x =>
                list.Add(x));
            comboCategory.ItemsSource = list;
        }
        private void populateSections()
        {
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            Queries.QueryBooks.getSections().ForEach(x =>
                list.Add(x));
            comboSection.ItemsSource = list;
        }
        private void buttonSearchAdd_Click(object sender, RoutedEventArgs e)
        {
            //if book does not exist in database {
            popTable();
            if (dg.Items.Count == 0 || checkFields())
            {
                if (Queries.QueryAccounts.level == 1)
                {
                    if (MessageBox.Show("Book does not exist in database.\nWould you like to add one now?",
                        "Not Found!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Window window = new Window_AddBook();
                        window.Owner = Window.GetWindow(this);
                        window.Closing += Window_Closing;

                        window.ShowDialog();
                    }
                }
                        
            }
            // }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            popTable();
        }

        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();
            string[] text = {
                textBookID.Text,
                textTitle.Text,
                comboAuthor.Text,
                textYear.Text,
                textQuantity.Text,
                textPages.Text,
                comboCategory.Text,
                comboSection.Text,
                textComments.Text
            };
            /*DataTable dt = Queries.QueryBooks.searchBook(text);
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
            List<Models.Book> books = Queries.QueryBooks.searchBook(text);
            dg.ItemsSource = books;
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Models.Book x in e.AddedItems)
            {
                textBookID.Text = x.BookID+"";
                textTitle.Text = x.Title;
                comboAuthor.Text = x.Author;
                textYear.Text = x.Year + "";
                textQuantity.Text = x.Quantity + "";
                textPages.Text = x.Pages + "";
                comboCategory.Text = x.Category + "";
                comboSection.Text = x.Section + "";
                textComments.Text = x.Comments + "";
            }
        }
        public void clearField()
        {
            textBookID.Clear();
            textComments.Clear();
            textPages.Clear();
            textQuantity.Clear();
            textTitle.Clear();
            textYear.Clear();
            comboAuthor.Text = "";
            comboCategory.Text = "";
            comboSection.Text = "";
            popTable();
        }
        private bool checkFields()
        {
            if ((textBookID.Text == "") &&
            (textComments.Text == "") &&
            (textPages.Text == "") &&
            (textQuantity.Text == "") &&
            (textTitle.Text == "") &&
            (textYear.Text == "") &&
            (comboAuthor.Text == "") &&
            (comboCategory.Text == "") &&
            (comboSection.Text == ""))
                return true;
            return false;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            clearField();
        }
        public void populateComboBoxes()
        {
            populateAuthors();
            populateCategories();
            populateSections();
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            Headers.DataHeaders.generateColumn(e);
        }
    }
}
