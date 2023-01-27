using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter a 4 digit year to check leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(((year%4) == 0 && (year%100) != 0) || (year%400) == 0)
            {
                Console.WriteLine("Leap Yaar");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }
    }
}
