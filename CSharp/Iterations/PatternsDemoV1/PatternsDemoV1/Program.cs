using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////block
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= i)
            //        {
            //            Console.Write("* ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            int n = 5;
            for (int i = 0; i <= n; i++)
            {

                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

            ////diagonals
            //int n = 11;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i +j == n+1 || i==j)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}


            ////diagonals with box
            //int n = 5;
            //int x = 97;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i == 1 || i == n || j == 1 || j == n || i + j == n + 1 || i == j)
            //        {
            //            Console.Write((char)(x++) + " ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
