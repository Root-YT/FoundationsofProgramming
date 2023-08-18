using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTypesV1
{
    class Program
    {
        static void Main(string[] args)
        {

            //function call or invoking

            ////1 Without Return Type and Without Parameters
            //Sum();

            ////2 With Return Type and Without Parameters
            //int result1 = Sum1();
            ////output
            //Console.WriteLine("Result is : "+ result1);

            ////3 Without Return Type and With Parameters
            //int a = 45;
            //int b = 55;
            //Sum2(a, b);

            //Sum2(12, 13);

            //Sum2(Sum1(), Sum1());

            //4 With Return Type and With Parameters - pure function (High reuse)

            int result = Sum3(10, 15);
            Console.WriteLine("My result is : "+ result);


            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            int result1 = Sum3(first, second);
            Console.WriteLine("My result is : " + result1);
        }

        //write your methods here


        //1 Without Return Type and Without Parameters - OOP

        public static void Sum()
        {
            //input
            //int i = 10;
            //int j = 20;
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());


            //process

            int result = first + second;

            //output

            Console.WriteLine(result);
        }

        //2 With Return Type and Without Parameters

        public static int Sum1()
        {
            //input
            //int i = 10;
            //int j = 20;
            Console.WriteLine("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());


            //process

            int result = first + second;

            //output
            return result;
           
        }


        //3 Without Return Type and With Parameters

        public static void Sum2(int i, int j)
        {
            //input - comes from parameters
          
            //process

            int result = i + j;

            //output

            Console.WriteLine("Printing from inside the method: "+ result);
        }

        //4 With Return Type and With Parameters - pure function (High reuse)

        public static int Sum3(int i, int j)
        {
            return i + j;
        }

    }
}
