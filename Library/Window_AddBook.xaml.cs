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
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// Interaction logic for Window_AddBook.xaml
    /// </summary>
    public partial class Window_AddBook : Window
    {
        public Window_AddBook()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            populateAuthors();
            populateCategories();
            populateSections();
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

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                string[] text = {
                textBookID.Text,
                textTitle.Text,
                comboAuthor.SelectedIndex==-1?comboAuthor.Text:comboAuthor.SelectedIndex+1+"",
                textYear.Text,
                textQuantity.Text,
                textQuantity.Text,
                textPages.Text,
                comboCategory.SelectedIndex==-1?comboCategory.Text:comboCategory.SelectedIndex+1+"",
                comboSection.SelectedIndex==-1?comboSection.Text:comboSection.SelectedIndex+1+"",
                textComments.Text
                };
                Queries.QueryBooks.addBook(text);

                MessageBox.Show("Succesfully added book!", "Success", MessageBoxButton.OK);
            }
            else
                MessageBox.Show("Please fill out all fields.", "Empty Data", MessageBoxButton.OK);
            
            
        }
        private bool isEmpty()
        {
            return textBookID.Text == "" ||
                textTitle.Text == "" ||
                comboAuthor.Text == "" ||
                textYear.Text == "" ||
                textQuantity.Text == "" ||
                textPages.Text == "" ||
                comboCategory.Text == "" ||
                comboSection.Text == "" ||
                textComments.Text == "";
        }
        
    }
}
