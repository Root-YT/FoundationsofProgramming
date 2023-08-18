using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsIfElseDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////limit check demo - eligible to vote?
            //IsEligibleToVote(12);
            //IsEligibleToVote(17);
            //IsEligibleToVote(18);
            //IsEligibleToVote(56);
            //IsEligibleToVote(100);


            ////range check demo - eligible to work in government office

            //Console.WriteLine("Age: 12 - "+ IsEligibleToWork(12));
            //Console.WriteLine("Age: 17 - " + IsEligibleToWork(17));
            //Console.WriteLine("Age: 18 - " + IsEligibleToWork(18));
            //Console.WriteLine("Age: 45 - " + IsEligibleToWork(45));
            //Console.WriteLine("Age: 60 - " + IsEligibleToWork(60));
            //Console.WriteLine("Age: 61 - " + IsEligibleToWork(61));

            ////slab check demo -  income tax percent

            //Console.WriteLine("Income: 500000 - "+ GetTaxPercentage(500000));
            //Console.WriteLine("Income: 5000000 - " + GetTaxPercentage(5000000));
            //Console.WriteLine("Income: 1500000 - " + GetTaxPercentage(1500000));
            //Console.WriteLine("Income: 700000 - " + GetTaxPercentage(700000));

            Console.WriteLine("12 - "+ GetSignWithZero(12));
            Console.WriteLine("0 - " + GetSignWithZero(0));
            Console.WriteLine("-12 - " + GetSignWithZero(-12));
        }


        public static string GetSignWithZero(int i)
        {
            if (i >= 0)
            {
                if (i == 0)
                {
                    return "Zero";
                }
                else
                {
                    return "Positive";
                }
            }
            else
            {
                return "Negative";
            }
        }

        public static string GetTaxPercentage(double income)
        {
            if (income <= 500000)
            {
                return "No Tax";
            }
            else if (income > 500000 && income <= 1000000)
            {
                return "10% Tax";
            }
            else if (income > 1000000 && income <= 2000000)
            {
                return "20% Tax";
            }
            else if (income > 2000000)
            {
                return "30% Tax";
            }
            else
            {
                return "Invalid Income Value";
            }
        }

        public static string IsEligibleToWork(int age)
        {
            const int LowerLimit = 18;
            const int UpperLimit = 60;

            if (age >= LowerLimit && age <= UpperLimit)
            {
                return "You are eligible to work";
            }
            else
            {
                return "You are not eligible to work";
            }
        }

        public static void IsEligibleToVote(int age)
        {
            const int VOTINGAGE = 18;
            if (age >= VOTINGAGE)
            {
                Console.WriteLine("Your age is : "+ age +". You are eligible to vote");
            }
            else
            {
                Console.WriteLine("Your age is : "+ age +". You are not eligible to vote");
            }
        }
        public static int GetInteger(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }
    }
}
