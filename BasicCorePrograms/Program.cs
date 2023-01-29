using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the program number you want to run");
            Console.WriteLine("1:FlipCoin \n2:LeapYer\n3:PowerOfTwo\n4:HarmonicNo.\n5:FindPrimeFactor\n6.ComputeQuotientRemainder\n7:SwapNumber\n8:CheckEvenOdd");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    FlipCoin.PercentCalculationOfHeadTail();
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    LeapYear.FindLeapYear();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    PowerOfTwo.TableOfPowerOfTwo();
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    HarmonicNumber.HarmonicNo();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    PrimeFactor.FindPrimeNumber();
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    QuotientRemainder.ComputeQuotientReminder();
                    Console.ReadLine();
                    break;
                case 7:
                    Console.Clear();
                    SwapNumber.SwapTwoNumber();
                    Console.ReadLine();
                    break;
                case 8:
                    Console.Clear();
                    EvenOdd.CheckEvenOdd();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
