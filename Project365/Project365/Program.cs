using System;
using System.Threading;
using System.Reflection;

namespace Project365
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramStart();
        }

        public static void ProgramStart()
        {
            string ConsoleRead;

            Console.WriteLine("Please type month and day on the Input line.");
            Console.WriteLine("For example, if you want to see the solution for the 20th May, type 'May Day20'");
            Console.Write("Input: ");
            ConsoleRead = Console.ReadLine();
            string[] temp = ConsoleRead.Split(' ');

            InvokeStringMethod(temp[0], temp[1]);
        }

        public static void Restart()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Program.ProgramStart();
        }

        public static void Restart(int waitTime)
        {
            Thread.Sleep(waitTime);
            Console.Clear();
            Program.ProgramStart();
        }

        private static string InvokeStringMethod(string typeName, string methodName)
        {
            Type calledType = Type.GetType("Project365." + typeName + "." + methodName);

            string s = (String)calledType.InvokeMember("main", BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);

            return s;
        }
    }
}
