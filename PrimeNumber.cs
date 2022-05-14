using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter a number to check if it is prime ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not a prime number");
                    break;
                }
                else
                {
                    Console.WriteLine(number + " is a prime number");
                }
            }
        }
    }
}
