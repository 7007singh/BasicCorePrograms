using System;

namespace BasicCorePrograms
{
    internal class LargestNumber
    {
        public static void FindLargestNumber()
        {
            Console.WriteLine("Enter any three number to find Largest one");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largest = 0;

            if(num1 > num2 && num1 > num3)   
            {
                largest = num1;
                Console.WriteLine("largest number: " + num1);
            }
            else if(num2 > num1 && num2 > num3)
            {
                largest = num2;
                Console.WriteLine("largest number: " + num2);
            }
            else
            {
                largest = num3;
                Console.WriteLine("largest number: " + num3);
            }
        }
    }
}
