using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void TableOfPowerOfTwo()
        {
            Console.WriteLine("Enter a number for printing power2 table");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                int number = (int)(double)Math.Pow(i, 2);
                Console.WriteLine("{0}^2={1}",i,number);
            }
        }
    }
}
