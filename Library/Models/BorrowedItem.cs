using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class BorrowedItem
    {
        Book _book;
        Student _student;
        DateTime _dateBorrowed;
        DateTime _dateReturned;
        DateTime _dateToBeReturned;
        int _fine;

        internal Student Student { get => _student; set => _student = value; }
        internal Book Book { get => _book; set => _book = value; }
        [DisplayName("Book")]
        public object BookId { get => Book.Title; set => Book = Queries.QueryBooks.book.Find(x => x.BookID==value as int?); }
        [DisplayName("Book ID")]
        public int iBookId { get => Book.BookID; }
        [DisplayName("Student")]
        public object StudentId { get => Student.Name; set => Student = Queries.QueryStudent.student.Find(x => x.StudentId == value as int?); }
        [DisplayName("Student ID")]
        public int iStudentId { get => Student.StudentId; }
        [DisplayName("Date Borrowed")]
        public DateTime DateBorrowed { get => _dateBorrowed; set => _dateBorrowed = value; }
        [DisplayName("Date Returned")]
        public DateTime DateReturned { get => _dateReturned; set => _dateReturned = value; }
        [DisplayName("Date to be Fined")]
        public DateTime DateToBeFined { get => _dateToBeReturned; set => _dateToBeReturned = value; }
        public int Fine { get => _fine; set => _fine = value; }
    }
}
