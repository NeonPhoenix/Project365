using System;
using System.Threading;

namespace Project365.January
{
    class Day5
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Find prime numbers starting from 1.");
            Console.WriteLine("Press any key when you want to stop. Program will stop at 1000.");

            int a = 0;

            while(!Console.KeyAvailable)
            {
                if(a == 1000)
                {
                    Console.WriteLine("Program has reached 1000.");
                    Program.Restart();
                }
                else
                {
                    if(IsPrime(a))
                    {
                        Console.WriteLine(a + " Is a Prime Number");
                        a++;
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        //Console.WriteLine(a + " Is not a Prime Number");
                        a++;
                    }
                }
            }

            Console.WriteLine("Key press detected.");
            Program.Restart();
        }

        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return false;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for(int i = 3; i <= boundary; i+=2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
