using System.Collections.Generic;
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
            /*DataTable dt = Queries.QueryStudent.getStudents(text);
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
            List<Models.Student> students = Queries.QueryStudent.getStudents(text);
            dg.ItemsSource = students;
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
            foreach (Models.Student x in e.AddedItems)
            {
                textStudentID.Text = x.StudentId+"";
                textFirstName.Text = x.FirstName;
                textLastName.Text = x.LastName;
                comboGrade.Text = x.Section;
            }
        }

        private void buttonSearchAdd_Click(object sender, RoutedEventArgs e)
        {
            popTable();
            if (dg.Items.Count == 0 || checkFields())
            {
                if (Queries.QueryAccounts.level == 1)
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
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if ((string)e.Column.Header == "Name")
                e.Cancel = true;
            Headers.DataHeaders.generateColumn(e);
        }
    }
}
