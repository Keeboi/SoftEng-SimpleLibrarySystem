using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Library
{
    /// <summary>
    /// Interaction logic for UserControl_Students.xaml
    /// </summary>
    public partial class UserControl_Students : UserControl
    {
        public UserControl_Students()
        {
            InitializeComponent();
            popTable();
            populateGrades();
        }
        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();
            string[] text = {
                textStudentID.Text,
                textFirstName.Text,
                textLastName.Text,
                comboGrade.Text
            };
            DataTable dt = Queries.QueryStudent.getStudents(text);
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

        private void populateGrades()
        {
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            Queries.QueryStudent.getSection().ForEach(x =>
                list.Add(x));
            comboGrade.ItemsSource = list;
        }
        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (DataRowView x in e.AddedItems)
            {
                textStudentID.Text = x.Row[0].ToString();
                textFirstName.Text = x.Row[1].ToString();
                textLastName.Text = x.Row[2].ToString();
                comboGrade.Text = x.Row[3].ToString();
            }
        }

        private void buttonSearchAdd_Click(object sender, RoutedEventArgs e)
        {
            popTable();
            if (dg.Items.Count == 0 || checkFields())
            {
                if (MessageBox.Show("Student does not exist in database.\nWould you like to add one now?",
                    "Not Found!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Window window = new Window_AddStudent();
                    window.Owner = Window.GetWindow(this);
                    window.ShowDialog();
                }

            }
        }
        public void clearField()
        {
            textStudentID.Clear();
            textFirstName.Clear();
            textLastName.Clear();
            comboGrade.SelectedIndex = -1;
            popTable();
        }
        private bool checkFields()
        {
            if ((textStudentID.Text == "") &&
            (textFirstName.Text == "") &&
            (textLastName.Text == "") &&
            (comboGrade.SelectedIndex == -1))
                return true;
            return false;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            textStudentID.Clear();
            textFirstName.Clear();
            textLastName.Clear();
            comboGrade.SelectedIndex = -1;
            popTable();
        }
    }
}
