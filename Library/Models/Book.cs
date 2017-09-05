using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Book
    {
        #region Variables

        string _title;
        int _id;
        string _author;
        int _year;
        int _pages;
        int _quantity;
        int _available;
        string _category;
        string _section;
        string _comments;

        #endregion

        #region Properties
        [DisplayName("Book ID")]
        public int BookID { get => _id; set => _id = value; }

        [DisplayName("Title")]
        public string Title { get => _title; set => _title = value; }

        [DisplayName("Author")]
        public string Author { get => _author; set => _author = value; }

        [DisplayName("Year")]
        public int Year { get => _year; set => _year = value; }

        [DisplayName("Pages")]
        public int Pages { get => _pages; set => _pages = value; }

        [DisplayName("Quantity")]
        public int Quantity { get => _quantity; set => _quantity = value; }

        [DisplayName("Available")]
        public int Available { get => _available; set => _available = value; }

        [DisplayName("Category")]
        public string Category { get => _category; set => _category = value; }

        [DisplayName("Section")]
        public string Section { get => _section; set => _section = value; }

        [DisplayName("Comments")]
        public string Comments { get => _comments; set => _comments = value; }
        #endregion
    }
}
