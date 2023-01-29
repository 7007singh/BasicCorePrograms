using System;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void HarmonicNo()
        {
            float sum = 0;
            Console.WriteLine("Enter the number of terms: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < N; i++)
            {
                Console.Write("1/{0}+",i);
                sum += 1/ (float)i;
            }
            Console.WriteLine("\nNth Narmonic Value: " + sum);
        }
    }
}
