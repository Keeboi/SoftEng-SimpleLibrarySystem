using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Date
{
    class DateCheck
    {
        public static bool compareDates(DateTime givenDate)
        {
            return givenDate <= DateTime.Now;
        }
        public static int getAmount(DateTime date)
        {
            return (DateTime.Now - date).Days;
        }
    }
}
