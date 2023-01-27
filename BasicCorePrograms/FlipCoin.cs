using System;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        public static void PercentCalculationOfHeadTail()
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Enter the number for flipping Coin");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for(int i = 0; i < n; i++)
            {
                double tossCoin = random.NextDouble();
                if(tossCoin < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Tail Count:{0} Head Count:{1} ", tailCount, headCount);
            double tailPercent = (double)(tailCount*100)/n;
            Console.WriteLine("Tail Percent:{0}%",tailPercent);
            Console.WriteLine("Head Percent:{0}%",(100-tailPercent));
        }
    }
}
