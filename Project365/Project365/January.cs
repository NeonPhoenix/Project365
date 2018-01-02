using System;
using System.Threading;

namespace Project365
{
    class January
    {
        private static void Restart()
        {
            Thread.Sleep(3000);
            Program.ProgramStart();
        }

        public static void Day1()
        {
            Console.WriteLine("Find Pi to the Nth Digit.");
            Console.WriteLine("Type a number between 1 and 15.");
            Console.Write("Input: ");
            string temp = Console.ReadLine();
            int nth = Convert.ToInt32(temp);

            if (nth >= 1)
            {
                if (nth <= 15)
                {
                    Console.WriteLine(Math.Round(Math.PI, nth));
                }
                else
                {
                    Console.WriteLine("Number needs to be between 1 and 15.");
                    Console.WriteLine("Please try again.");
                    Day1();
                }
            }
            else
            {
                Console.WriteLine("Number needs to be between 1 and 15.");
                Console.WriteLine("Please try again.");
                Day1();
            }

            Restart();
        }

        public static void Day2()
        {
            Console.WriteLine("Find E to the Nth Digit.");
            Console.WriteLine("Type a number between 1 and 15.");
            Console.Write("Input: ");

            string temp = Console.ReadLine();
            int nth = Convert.ToInt32(temp);

            if(nth >= 1)
            {
                if(nth <= 15)
                {
                    Console.WriteLine(Math.Round(Math.E, nth));
                }
                else
                {
                    Console.WriteLine("Number needs to be between 1 and 15.");
                    Console.WriteLine("Please try again.");
                    Day2();
                }
            }
            else
            {
                Console.WriteLine("Number needs to be between 1 and 15.");
                Console.WriteLine("Please try again.");
                Day2();
            }
        }
    }
}
