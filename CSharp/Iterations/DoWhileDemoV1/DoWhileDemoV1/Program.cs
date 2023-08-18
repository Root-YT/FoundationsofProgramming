using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input = "";

            //do
            //{

            //    Console.WriteLine("Enter the first number: ");
            //    int first = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second number: ");
            //    int second = int.Parse(Console.ReadLine());
            //    int result = first + second;

            //    Console.WriteLine("The sum is : "+ result);

            //    Console.WriteLine("Do you want to continue? Press Y to sum another set of numbers");
            //    input = Console.ReadLine();


            //} while (input == "Y" || input =="y");



            string input = "Y";

            while(input=="Y")
            {

                Console.WriteLine("Enter the first number: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                int second = int.Parse(Console.ReadLine());
                int result = first + second;

                Console.WriteLine("The sum is : " + result);

                Console.WriteLine("Do you want to continue? Press Y to sum another set of numbers");
                input = Console.ReadLine();


            } 

        }
    }
}
