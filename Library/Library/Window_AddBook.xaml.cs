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
        }
        
        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully added book!", "Success", MessageBoxButton.OK);
        }
    }
}
