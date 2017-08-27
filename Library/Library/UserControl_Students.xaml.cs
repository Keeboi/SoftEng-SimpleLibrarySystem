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
    /// Interaction logic for UserControl_Students.xaml
    /// </summary>
    public partial class UserControl_Students : UserControl
    {
        public UserControl_Students()
        {
            InitializeComponent();
            popTable();
        }
        public void popTable()
        {
            dg.Columns.Clear();
            dg.Items.Refresh();
            SqlConnector sql = new SqlConnector("localhost", 3306, "root", "", "db_library");
            sql.openConnection();
            string query = "select student_id as \"Student ID\", " +
                "student_fname as \"Student First Name\", " +
                "student_lname as \"Student Last Name\", " +
                "tblgrades.student_section as Section from tblstudents " +
                "join tblgrades on tblstudents.grade_id = tblgrades.grade_id " +
                "where student_id like '" + textStudentID.Text + "%' and " +
                "student_fname like '" + textFirstName.Text + "%' and " +
                "student_lname like '" + textLastName.Text + "%' and " +
                "tblgrades.grade like '" + comboGrade.Text + "%'";

            if (sql.getData(query) != null) // table is a DataTable
            {
                foreach (System.Data.DataColumn col in sql.getData(query).Columns)
                {
                    dg.Columns.Add(
                      new DataGridTextColumn
                      {
                          Header = col.ColumnName,
                          Binding = new Binding(string.Format("{0}", col.ColumnName))
                      });
                }

                dg.DataContext = sql.getData(query);
            }
            sql.closeConnection();
            
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*var student = (Student)dg.SelectedItem;
            textStudentID.Text = student.id;
            textFirstName.Text = student.fName;
            textLastName.Text = student.lName;
            comboGrade.Text = student.grade;*/
            //DataGrid gd = sender as DataGrid;
            //Student student = (Student)e.AddedItems;
            //textStudentID.Text = e.AddedItems.;
            //textFirstName.Text = student.fName;
            //textLastName.Text = student.lName;
            //comboGrade.Text = student.grade;
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            list.Add("student section 1");
            list.Add("student section 2");
            comboGrade.ItemsSource = list;
            foreach (System.Data.DataRowView x in e.AddedItems)
            {
                textStudentID.Text = x.Row[0].ToString();
                textFirstName.Text = x.Row[1].ToString();
                textLastName.Text = x.Row[2].ToString();
                comboGrade.Text = x.Row[3].ToString();
            }
                //table.Rows[i].Cells[j].Value.ToString()
        }
    }
    class Student
    {
        public string id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string grade { get; set; }
        public Student(params string[] input)
        {
            id = input[0];
            fName = input[1];
            lName = input[2];
            grade = input[3];
        }
    }
}
