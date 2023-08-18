using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperationsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1, a :"+ GetColor(1, 'a'));
            Console.WriteLine("2, d :" + GetColor(2, 'd'));
            Console.WriteLine("5, e :" + GetColor(5, 'e'));
            Console.WriteLine("3, b :" + GetColor(3, 'b'));
            Console.WriteLine("5, f :" + GetColor(5, 'f'));
        }


        public static string GetColor(int row, char col)
        {
            return (row + col) % 2 == 0 ? "Black" : "White"; //terse - compact
        }
    }
}
