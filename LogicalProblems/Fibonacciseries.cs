﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Fibonacciseries
    {
        int a = 0;
        int b = 1;
        int c;
        public void FindFibonacci()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        
            for(int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
