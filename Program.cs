using System;

namespace LogicalProgram
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("\n Press 1  to print fibonacci series \n Press 2 to check perfect number" +
                "\n Press 3 to check if a number is prime \n Press 4 to reverse a number " +
                "\n Press 5 to find coupoun numbers \n Press 6 to display stopwatch time ");

            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Series();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case 4:
                    ReverseNumber number = new ReverseNumber();
                    number.Reverse();
                    break;
                case 5:
                    Coupoun coupoun = new Coupoun();
                    coupoun.CoupounNumber();
                    break;
                case 6:
                    StopwatchTime time = new StopwatchTime();
                    time.ElapsedTime();
                    break;
                default:
                    Console.Write("Invalid Choice");
                    break;
            }
        }
    }
}
