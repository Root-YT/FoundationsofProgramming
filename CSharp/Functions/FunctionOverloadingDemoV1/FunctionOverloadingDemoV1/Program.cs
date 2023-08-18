using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloadingDemoV1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Sum(10.0f);
            //double result = CalcArea(10.0, 20.0);
            //Console.WriteLine(result);

            //double vol = CalcVolume(10, 20, 30);
            //Console.WriteLine(vol);

            //Console.WriteLine(10);
            //Console.WriteLine("Anand");
            //Sum(20L);

            //please don't go for this...
            Sample(10, "anand");
            Sample("anand", 10);
        }


        public static void Sample(string s, int i)
        {
            Console.WriteLine("string and int");
        }

        public static void Sample(int i, string s)
        {
            Console.WriteLine("int and string");
        }

        public static void Sum()
        {
            Console.WriteLine("Sum Method");
        }

        public static void Sum(int i)
        {
            Console.WriteLine("New Sum Method");
        }

        public static void Sum(long i)
        {
            Console.WriteLine("New Long Sum Method");
        }

        public static void Sum(float i)
        {
            Console.WriteLine("New Float Sum Method");
        }

        public static double Product(double a, double b)
        {
            return a * b;
        }

        public static double Product(double a, double b, double c)
        {
            return a * b * c;
        }

        public static double CalcArea(double length, double width)
        {
            return Product(length, width);
        }

        public static double CalcVolume(double length, double width, double height)
        {
            //return Product(Product(length, width), height);
            return Product(length, width, height);
        }

    }
}
