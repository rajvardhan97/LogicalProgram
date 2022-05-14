using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.Write("Enter a number to reverse it "); 
            int number = Convert.ToInt32(Console.ReadLine());
			int reverse = 0;

			while (number > 0)				
			{
				reverse = reverse * 10 + number % 10;		
				number = number / 10;
			}

			Console.WriteLine("Reversed number: " + reverse);
		}
    }
}
