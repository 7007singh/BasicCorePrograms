using System;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void TableOfPowerOfTwo()
        {
            Console.WriteLine("Enter a number for printing power2 table");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 31;
            for(int i = 0; i < n; i++)
            {
                int number = (int)(double)Math.Pow(2, i);
                Console.WriteLine("2^{0}={1}",i,number);
            }
        }
    }
}
