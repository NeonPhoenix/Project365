using System;

namespace Project365.January
{
    class Day4
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Find all prime factors of a given number");
            Console.Write("Please enter your number: ");

            int a, b;
            a = int.Parse(Console.ReadLine());

            for(b = 2; a > 1; b++)
            {
                if(a % b == 0)
                {
                    int x = 0;

                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }

                    Console.WriteLine("{0} is a prime factor {1} times!", b, x);
                }
            }

            Program.Restart();
        }
    }
}
