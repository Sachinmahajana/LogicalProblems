using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public void FindReversnumber()
        {
            int result = 0; int rem;
            Console.WriteLine("Enter the number which one reverse: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while(number != 0)
            {
                rem = number % 10;
                result = result * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
