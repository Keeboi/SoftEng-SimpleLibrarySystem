using System;
using System.Windows;
using System.Windows.Controls;

namespace Library
{
    /// <summary>
    /// Interaction logic for UserControl_Accounts.xaml
    /// </summary>
    public partial class UserControl_Accounts : UserControl
    {
        public UserControl_Accounts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// <summary>
            /// if book does not exist in database {
            /// </summary>
            if (MessageBox.Show("User does not exist in database.\nWould you like to add one now?", "Not Found!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Window_AddUser register = new Window_AddUser();
                register.Show();
            }
        }
        public void popTable()
        {
        }
    }
}
