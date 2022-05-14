using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Coupoun
    {
        public void CoupounNumber()
        {
            Console.Write("Enter the numbers of coupouns you want ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Random random = new Random();
                Console.Write("\n" + random.Next(100, 1000));   
            }
        }
    }
}
