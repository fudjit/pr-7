using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_7
{
    internal class Date : Triad
    {
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get { return _day; }
            set { if (value > 0 && value < 31) _day = value;
                else throw new ArgumentOutOfRangeException(); }
        }
        public int Month
        {
            get { return _month; }
            set
            {
                if (value > 0 && value < 12) _month = value;
                else throw new ArgumentOutOfRangeException();
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 0) _year = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public Date(int day, int month, int year) : base(day,month,year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public static bool operator >(Date firstDate, Date secondDate)
        {
            if ((firstDate.Year > secondDate.Year || firstDate.Year == secondDate.Year) && firstDate.Month > secondDate.Month && firstDate.Day > secondDate.Day)
                return true;
            else return false;
        }
        public static bool operator <(Date firstDate, Date secondDate)
        {
            return ((firstDate.Year < secondDate.Year || firstDate.Year == secondDate.Year) && firstDate.Month < secondDate.Month && firstDate.Day < secondDate.Day);
        }
    }
}
