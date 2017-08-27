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
    /// Interaction logic for Window_Login.xaml
    /// </summary>
    public partial class Window_Login : Window
    {
        public Window_Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (textUsername.Text == "admin" && textPassword.Password.ToString() == "admin")
            {
                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }
            else
                MessageBox.Show("Username or password doesn't exist.\nPlease contact administrator or librarian for registration.", "Invalid Login!", MessageBoxButton.OK);
        }
    }
}
