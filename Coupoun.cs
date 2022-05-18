using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Coupoun
    {
        public string Generate()
        {
            string code = Convert.ToString(new Random().Next(100, 1000));
            return code;
        }
        public void CoupounNumber()
        {
            Console.Write("Enter the numbers of coupouns you want ");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] CoupounList = new string[number];
            string coupoun = Generate();

            for (int i = 0; i < number; i++)
            {
                while (Array.Exists(CoupounList, element => element == coupoun))
                {
                    coupoun = Generate();
                }
                CoupounList[i] = coupoun;
            }
            Console.WriteLine("Coupouns Generated are : \n");
            for(int i =0; i < number; i++)
            {
               Console.WriteLine(CoupounList[i]);
            }
        }
    }
}
