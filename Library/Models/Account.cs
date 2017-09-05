using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Account
    {
        int _id;
        string _fname;
        string _lname;
        string _accountType;
        string _user;
        string _pass;

        public int Id { get => _id; set => _id = value; }
        public string Fname { get => _fname; set => _fname = value; }
        public string Lname { get => _lname; set => _lname = value; }
        public string AccountType { get => _accountType; set => _accountType = value; }
        public string User { get => _user; set => _user = value; }
    }
}
