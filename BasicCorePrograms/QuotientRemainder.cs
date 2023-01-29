using System;

namespace BasicCorePrograms
{
    internal class QuotientRemainder
    {
        public static void ComputeQuotientReminder()
        {
            Console.WriteLine("Enter the Divident, Divisor to find Quotient and remainder Respectively");
            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = (divident / divisor); 
            int Remainder = (divident % divisor);
            Console.WriteLine("Quotient:" + Quotient);
            Console.WriteLine("Remainder:" + Remainder);
        }
    }
}
