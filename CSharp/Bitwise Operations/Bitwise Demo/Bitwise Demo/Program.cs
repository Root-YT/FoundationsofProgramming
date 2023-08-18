using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //int x = 5; //101
            //int y = 3; //011

            //Console.WriteLine("OR  : " + (x | y));// 111 =7
            //Console.WriteLine("AND : "+ (x & y)); // 001 = 1
            //Console.WriteLine("XOR : "+ (x ^ y)); // 110 = 6

            //int x = 0;
            //int stairs = 8;
            //x = x | stairs; //to set the bit
            //Console.WriteLine(x);
            //int nonsomking = 32;
            //x = x | nonsomking;
            //Console.WriteLine(x);

            ////check if set = AND with that bitmask

            //Console.WriteLine(x & nonsomking); //greater than 0 means set else not set

            //x = x & (~nonsomking); //to unset a bit
            //Console.WriteLine(x);
            //Console.WriteLine(x & nonsomking);

            //int x = 5;
            //int y = 3;

            //int z = x ^ y;
            //Console.WriteLine(z);
            //Console.WriteLine(z ^ x);
            //Console.WriteLine(z ^ y);


            //int x = 4;

            //Console.WriteLine(x << 1);
            //Console.WriteLine(x << 2);

            int x = -16;

            Console.WriteLine(x >> 1);
            Console.WriteLine(x >> 2);

        }
    }
}
