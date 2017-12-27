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
            Console.WriteLine("This is a test.");

            Restart();
        }
    }
}
