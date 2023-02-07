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
           
            Primenumber myObj1 = new Primenumber();
            myObj1.FindPrimeNumber();
            Console.ReadLine();
        }
    }
}
