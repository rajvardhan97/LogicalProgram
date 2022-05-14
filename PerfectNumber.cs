using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int number, sum = 0;
            
            Console.Write("Enter Number To Check : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
           
            if (sum == number)
            {
                Console.WriteLine(number + " Is A Perfect Number");
            }
            else
                Console.WriteLine(number + " Is Not A Perfect Number");

        }
    }
}
