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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserControl_Books books = new UserControl_Books();
        UserControl_Borrow borrow = new UserControl_Borrow();
        UserControl_Return returnB = new UserControl_Return();
        UserControl_Students students = new UserControl_Students();
        UserControl_Accounts accounts = new UserControl_Accounts();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBooks_Click(object sender, RoutedEventArgs e)
        {
            resetStackPanel();
            stackPanel.Children.Add(books);
            books.textBookID.Clear();
            books.textComments.Clear();
            books.textPages.Clear();
            books.textQuantity.Clear();
            books.textTitle.Clear();
            books.textYear.Clear();
            books.comboAuthor.Text = "";
            books.comboCategory.Text = "";
            books.comboSection.Text = "";
            books.popTable();
        }

        private void buttonBorrow_Click(object sender, RoutedEventArgs e)
        {
            resetStackPanel();
            stackPanel.Children.Add(borrow);
            borrow.popTable();
        }

        private void buttonReturn_Click(object sender, RoutedEventArgs e)
        {
            resetStackPanel();
            stackPanel.Children.Add(returnB);
            returnB.popTable();
        }

        private void buttonStudents_Click(object sender, RoutedEventArgs e)
        {
            resetStackPanel();
            stackPanel.Children.Add(students);
            students.popTable();
        }
        private void buttonAccounts_Click(object sender, RoutedEventArgs e)
        {
            resetStackPanel();
            stackPanel.Children.Add(accounts);
            accounts.popTable();
        }
        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            Window_Login login = new Window_Login();
            login.Show();
            Close();
        }
        private void resetStackPanel()
        {
            stackPanel.Children.Remove(borrow);
            stackPanel.Children.Remove(books);
            stackPanel.Children.Remove(returnB);
            stackPanel.Children.Remove(students);
            stackPanel.Children.Remove(accounts);
        }
    }
}
