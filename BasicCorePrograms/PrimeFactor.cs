using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactor
    {
        public static void FindPrimeNumber()
        {
            Console.WriteLine("Input Number to find Prime or not");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorCount = 0;

            for(int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    factorCount++;
                }
            }

            if(factorCount == 2)
            {
                Console.WriteLine("{0} is a Prime Number",n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number",n);
            }
        }
    }
}
