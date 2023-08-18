using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1991: "+ IsLeapYear(1991));
            Console.WriteLine("1993: " + IsLeapYear(1993));
            Console.WriteLine("2003: " + IsLeapYear(2003));
            Console.WriteLine("1992: " + IsLeapYear(1992));
            Console.WriteLine("1996: " + IsLeapYear(1996));
            Console.WriteLine("2000: " + IsLeapYear(2000));
            Console.WriteLine("1900: " + IsLeapYear(1900));
            Console.WriteLine("2100: " + IsLeapYear(2100));
        }

        //public static bool IsLeapYear(int year)
        //{
        //    if (year % 4 == 0)
        //    {
        //        if (year % 100 == 0)
        //        {
        //            if (year % 400 == 0)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        public static bool IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        public static bool IsATypicalCommonYear(int year)
        {
            return year % 100 == 0 && year % 400 != 0;
        }

        public static bool IsLeapYear(int year)
        {
            return IsTypicalLeapYear(year) && !IsATypicalCommonYear(year);
        }
    }
}
