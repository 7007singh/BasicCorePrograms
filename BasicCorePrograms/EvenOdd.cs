using System;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Please enter a Number to check Even or Odd");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is Even", number);
            }
            else
            {
                Console.WriteLine("{0} is Odd", number);
            }
        }
    }
}
