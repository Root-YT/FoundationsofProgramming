using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIODemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write your code here
            //Console.Write("Welcome to C# Code Demo");
            Console.WriteLine("Welcome to C# Code Demo");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); // \n terminated
            Console.WriteLine("Your name is : "+ name);

            Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : "+ age);

            Console.WriteLine("Enter your height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your height is : "+ height.ToString("F2"));

            Console.WriteLine("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Your salary is : "+ salary.ToString("C3"));

            Console.WriteLine("Are you married? ");
            bool married = bool.Parse(Console.ReadLine());
            Console.WriteLine("Married: "+ married);


        }
    }
}
