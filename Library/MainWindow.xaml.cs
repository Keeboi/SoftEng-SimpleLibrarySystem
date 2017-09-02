using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

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
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Application already running. Only one instance of this application is allowed");
                Application.Current.Shutdown();
            }
            resetButtonColors();
        }

        private void buttonBooks_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
            buttonBooks.Background = Brushes.LightGreen;
            resetStackPanel();
            stackPanel.Children.Add(books);
            books.clearField();
            books.populateComboBoxes();
        }

        private void buttonBorrow_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
            buttonBorrow.Background = Brushes.LightGreen;
            resetStackPanel();
            stackPanel.Children.Add(borrow);
            borrow.clearField();
            borrow.popTable();
        }

        private void buttonReturn_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
            buttonReturn.Background = Brushes.LightGreen;
            resetStackPanel();
            stackPanel.Children.Add(returnB);
            returnB.clearField();
            returnB.popTable();
        }

        private void buttonStudents_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
            buttonStudents.Background = Brushes.LightGreen;
            resetStackPanel();
            stackPanel.Children.Add(students);
            students.clearField();
            students.popTable();
        }
        private void buttonAccounts_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
            buttonAccounts.Background = Brushes.LightGreen;
            resetStackPanel();
            stackPanel.Children.Add(accounts);
            accounts.popTable();
        }
        private void buttonLogout_Click(object sender, RoutedEventArgs e)
        {
            resetButtonColors();
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
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Window_Login login = new Window_Login();
            login.Show();
        }
        private void resetButtonColors()
        {
            buttonAccounts.Background = Brushes.White;
            buttonBooks.Background = Brushes.White;
            buttonBorrow.Background = Brushes.White;
            buttonLogout.Background = Brushes.White;
            buttonReturn.Background = Brushes.White;
            buttonStudents.Background = Brushes.White;
        }
    }
}