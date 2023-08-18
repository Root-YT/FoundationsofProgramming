using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example e1 = new Example();
            ////e1.B();
            ////e1.A();
            //e1.B(45);

            Sample s1 = new Sample();
            s1.A();
            Console.WriteLine(Sample.x);
            Sample.x = 65;
            Console.WriteLine(Sample.x);
        }
    }

    class Example
    {
        int i = 10; //non-static field, instance field or object field - global

        public void A()
        {
            int j = 30; //local variable or method variable
            Console.WriteLine(j);
            //Console.WriteLine(i);
            int i = 20; //redeclaring i as local variable - hides global variable i
            Console.WriteLine(i);
        }
        public void B(int x)
        {
            Console.WriteLine(x); //parameter or local variable
            //Console.WriteLine(i);
            //int i = 60;
            //block
            {
                int y = 15; //block level variable
                Console.WriteLine(y);
                int i = 50; //local variable redeclaration
                Console.WriteLine(i);
            }
            
        }
    }

    //Field vs Variable
    class Sample
    {
        int i; //fields are auto initialized

       public static int x = 50; //static field 
        public void A()
        {
            i = 50;
            Console.WriteLine(i);
            
        }
      
        //public void B()
        //{
        //    int i;
        //    i = 40;
        //    Console.WriteLine(i);
        //}

    }


}
