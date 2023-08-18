using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = GetInteger("Enter your age: ", 25);
            Console.WriteLine("Age is : "+ age);
        }

        //function overloading
        public static int GetInteger(string message, int lowerbound)
        {
            Console.WriteLine(message);
            int temp = int.Parse(Console.ReadLine());
            if (temp >= lowerbound)
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Invalid input value. Please enter a value above "+lowerbound);
                return GetInteger(message, lowerbound);
            }
        }

        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }


    }
}
