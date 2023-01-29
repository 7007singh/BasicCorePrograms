using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the program number you want to run");
            Console.WriteLine("1:FlipCoin \n2:LeapYer\n3:PowerOfTwo\n4:HarmonicNo.\n5:FindPrimeFactor\n6.ComputeQuotientRemainder");
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
                case 3:
                    PowerOfTwo.TableOfPowerOfTwo();
                    Console.ReadLine();
                    break;
                case 4:
                    HarmonicNumber.HarmonicNo();
                    Console.ReadLine();
                    break;
                case 5:
                    PrimeFactor.FindPrimeNumber();
                    Console.ReadLine();
                    break;
                case 6: 
                    QuotientRemainder.ComputeQuotientReminder();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
