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
            Queries.QueryPopulate.populate();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnector cn = new SqlConnector("localhost", 3306, "root", "", "db_library");
            Dictionary<string, string> login = Queries.QueryAccounts.loginUser(textUsername.Text, textPassword.Password.ToString());
            if (login != null)
            {
                if (textUsername.Text == login.Keys.First() && textPassword.Password.ToString() == login.Values.First())
                {
                    if (cn.openConnection())
                    {
                        MainWindow main = new MainWindow();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Could not connect to the database!", "Connection Error", MessageBoxButton.OK);
                    }
                }
            }
            else
                MessageBox.Show("Username or password doesn't exist.\nPlease contact administrator or librarian for registration.", "Invalid Login!", MessageBoxButton.OK);
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textUsername.Text = "";
            textPassword.Password = "";
        }
    }
}
