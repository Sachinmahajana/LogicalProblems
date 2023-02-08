using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Logical Programs");
            Console.WriteLine("\n1.Primenumber\n2.Fibonacci\n3.ReverseNumber\n4.PerfectNumber\n5.CouponNumber\n6.DayOfWeek");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                // Q1 PrimeNumber
                case 1:
                    Primenumber myObj1 = new Primenumber();
                    myObj1.FindPrimeNumber();
                    break;
                // Q2 Fibonacci Series
                case 2:
                    Fibonacciseries myObj2 = new Fibonacciseries();
                    myObj2.FindFibonacci();
                    break;
                // Q3 Reverse Number
                case 3:
                    ReverseNumber myObj3 = new ReverseNumber();
                    myObj3.FindReversnumber();
                    break;
                // Q4 PerfectNumber
                case 4:
                    PerfectNumber myObj4 = new PerfectNumber();
                    myObj4.FindPerfectNumber();
                    break;
                // Q5 CouponNumber
                case 5:
                    Couponnumber myObj5 = new Couponnumber();
                    myObj5.CouponNumberGet();
                    break;
                case 6:
                    DayOfWeek myObj6 = new DayOfWeek();
                    myObj6.DayOfWeekFun();
                    break;
            }
        
            Console.ReadLine();
        }
    }
}
