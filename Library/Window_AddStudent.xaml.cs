using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for Window_AddStudent.xaml
    /// </summary>
    public partial class Window_AddStudent : Window
    {
        public Window_AddStudent()
        {
            InitializeComponent();
            populateGrade();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmpty())
            {
                    string[] text = {
                    textStudentID.Text,
                    textFirstName.Text,
                    textLastName.Text,
                    comboSection.SelectedIndex+1+""
                };
                    Queries.QueryStudent.addStudent(text);

                    MessageBox.Show("Succesfully added student!", "Success", MessageBoxButton.OK);
            }
            else
                MessageBox.Show("Please fill out all fields.", "Empty Data", MessageBoxButton.OK);

        }

        private void populateGrade()
        {
            System.Collections.ObjectModel.ObservableCollection<string> list = new System.Collections.ObjectModel.ObservableCollection<string>();
            Queries.QueryStudent.getSection().ForEach(x =>
                list.Add(x));
            comboSection.ItemsSource = list;
        }
        private bool isEmpty()
        {
            return textStudentID.Text == "" ||
                textFirstName.Text == "" ||
                textLastName.Text == "" ||
                comboSection.Text == "";
        }
    }
}
