using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the program number you want to run");
            Console.WriteLine("1:FlipCoin \n2:LeapYer");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin.PercentCalculationOfHeadTail();
                    Console.ReadLine();
                    break;
                case 2:
                    LeapYear.FindLeapYear();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
