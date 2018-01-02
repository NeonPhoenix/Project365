using System;


namespace Project365.January
{
    class Day1
    {
        public static void main()
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
                    Day1.main();
                }
            }
            else
            {
                Console.WriteLine("Number needs to be between 1 and 15.");
                Console.WriteLine("Please try again.");
                Day1.main();
            }

            Program.Restart();
        }

    }
}
