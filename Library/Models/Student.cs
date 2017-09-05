using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Student
    {
        #region Variables
        int _id;
        string _fName;
        string _lName;
        string _section;
        int _grade;

        #endregion

        #region Properties
        public string Name { get => _fName + " " + _lName; }
        [DisplayName("Student ID")]
        public int StudentId { get => _id; set => _id = value; }
        [DisplayName("First Name")]
        public string FirstName { get => _fName; set => _fName = value; }
        [DisplayName("Last Name")]
        public string LastName { get => _lName; set => _lName = value; }
        [DisplayName("Grade")]
        public int Grade { get => _grade; set => _grade = value; }
        [DisplayName("Section")]
        public string Section { get => _section; set => _section = value; }
        #endregion
    }
}
