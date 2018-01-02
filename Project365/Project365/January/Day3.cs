using System;
using System.Collections.Generic;

namespace Project365.January
{
    class Day3
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Find Fibonacci to the Nth Digit");
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int nthDigit = Convert.ToInt32(input);

            List<int> fibList = new List<int>();
            int value = 0;

            fibList.Add(0);
            fibList.Add(1);

            for(int i = 0; i <= nthDigit; i++)
            {
                if(fibList.Count < nthDigit)
                {
                    value = fibList[i] + fibList[i + 1];

                    fibList.Add(value);
                }
                else
                {
                    fibList.ForEach(item => Console.Write(item + ", "));
                    Program.Restart();
                }
            }
        }
    }
}
