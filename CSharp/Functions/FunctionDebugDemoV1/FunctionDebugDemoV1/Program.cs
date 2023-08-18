using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDebugDemoV1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given the basic pay and the DA and TA percentage, find the net salary after deduction of 8% PF
            const double PF = 8.0;
            double basicpay = GetDouble("Enter the basic pay: ");
            double TAPercent = GetDouble("Enter the TA percent: ");
            double DAPercent = GetDouble("Enter the DA percent: ");

            double DAValue = CalcPercentage(basicpay, DAPercent);
            double TAValue = CalcPercentage(basicpay, TAPercent);
            double PFDeduction = CalcPercentage(basicpay, PF);

            double NetSalary = basicpay + DAValue + TAValue - PFDeduction;
            Console.WriteLine("Salary is : " + NetSalary);


        }

        public static double CalcPercentage(double amount, double percent)
        {
            return percent / 100.0 * amount;
        }



        public static double GetDouble(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }


       
    }
}
