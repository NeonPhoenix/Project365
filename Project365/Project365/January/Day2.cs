using System;

namespace Project365.January
{
    class Day2
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Find E to the Nth Digit.");
            Console.WriteLine("Type a number between 1 and 15.");
            Console.Write("Input: ");

            string temp = Console.ReadLine();
            int nth = Convert.ToInt32(temp);

            if (nth >= 1)
            {
                if (nth <= 15)
                {
                    Console.WriteLine(Math.Round(Math.E, nth));
                }
                else
                {
                    Console.WriteLine("Number needs to be between 1 and 15.");
                    Console.WriteLine("Please try again.");
                    Day2.main();
                }
            }
            else
            {
                Console.WriteLine("Number needs to be between 1 and 15.");
                Console.WriteLine("Please try again.");
                Day2.main();
            }

            Program.Restart();
        }
    }
}
