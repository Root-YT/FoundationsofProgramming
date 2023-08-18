using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: "+ GetDay(1));
            Console.WriteLine("7: " + GetDay(7));
            Console.WriteLine("9: " + GetDay(9));
            Console.WriteLine("17: " + GetDay(17));
            Console.WriteLine("19: " + GetDay(19));
            Console.WriteLine("31: " + GetDay(31));
        }

        public static string GetDay(int date)
        {
            string day = "";

            switch (date % 7) //0-6
            {
                case 0:
                    day = "Sunday";
                    break;

                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    day="Invalid Value";
                    break;
            }
            return day;
        }
    }
}
