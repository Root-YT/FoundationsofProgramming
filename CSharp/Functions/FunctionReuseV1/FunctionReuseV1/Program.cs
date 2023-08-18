using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionReuseV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //given the radius find the perimeter of the circle
            //Console.WriteLine("Enter the radius: ");
            //double radius = double.Parse(Console.ReadLine());

            //double radius = GetDouble("Enter the radius: ");
            //double perimeter = 2 * Math.PI * radius;

            //PrintMessage("Perimeter is : " + perimeter);

            //int age = GetInteger("Enter the age: ");
            //Console.WriteLine(age);

            //int height = GetInteger("Enter the height: ");
            //Console.WriteLine(height);


            //double length = GetDouble("Enter the length: ");
            //double width = GetDouble("Enter the width: ");

            
            //PrintMessage("Area is : " + GetArea(length, width));

            //given the bill amount, find the tips to be paid at 5%

            double amount = GetDouble("Enter the bill amount: ");
            PrintMessage("The tips to be paid is : " + CalcTips(amount));

        }


        public static double CalcTips(double amount)
        {
            return 5.0 / 100.0 * amount;
        }



        public static double GetArea(double length, double width)
        {
            double area = length * width;
            return area;
        }


        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetLine()
        {
            return Console.ReadLine();
        }

        public static int GetInteger(string message)
        {
            PrintMessage(message);
            int temp = int.Parse(GetLine());
            return temp;
        }

        public static float GetFloat(string message)
        {
            PrintMessage(message);
            float temp = float.Parse(GetLine());
            return temp;
        }

        public static long GetLongInteger(string message)
        {
            PrintMessage(message);
            long temp = long.Parse(GetLine());
            return temp;
        }

        public static double GetDouble(string message)
        {
            PrintMessage(message);
            double temp = double.Parse(GetLine());
            return temp;
        }

        



    }
}
