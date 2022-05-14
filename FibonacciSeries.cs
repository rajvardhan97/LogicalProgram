using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public void Series()
        {
            int first_term = 0, second_term = 1, next_term;
            Console.WriteLine("Enter the number of terms: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<number;i++)
            {
                Console.Write(first_term + " ");
                next_term = first_term + second_term;
                first_term = second_term;
                second_term = next_term;
            }
        }
    }
}
