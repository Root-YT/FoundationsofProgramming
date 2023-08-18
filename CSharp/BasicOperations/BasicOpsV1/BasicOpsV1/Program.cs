using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOpsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int overflow
            //int i = 2147483647;
            //int j = 2147483647;
            //long k = (long)i + j;
            //Console.WriteLine(k);


            //int i = 10;
            //int j = 3;
            //int k = i / j;
            //Console.WriteLine(k);

            //int i = 10;
            //int j = 3;
            //float k = (float)i / j;
            //Console.WriteLine(k);

            //Console.WriteLine(Math.PI);

            //int a = 24;
            //int ans = (int)Math.Sqrt(a);
            //Console.WriteLine(ans);

            //Console.WriteLine(Math.Pow(5, 3));
            //double result = Math.Pow(2, 15);
            //Console.WriteLine(result);

            //int x = -5;
            //Console.WriteLine(Math.Abs(x));

            //object creation for random class
            Random r = new Random();
            //int temp = r.Next(); // 0 to 2147483647

            //int temp = r.Next(101); //0 to 100

            int temp = r.Next(10, 21); //10 to 20
            Console.WriteLine(temp);


        }
    }
}
