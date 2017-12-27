using System;
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

            if(temp.Length > 2)
            {
                InvokeStringMethodParam(temp[0], temp[1], temp[2]);
            }
            else
            {
                InvokeStringMethod(temp[0], temp[1]);
            }
            
        }

        private static string InvokeStringMethod(string typeName, string methodName)
        {
            Type calledType = Type.GetType("Project365." + typeName);

            string s = (String)calledType.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, null);

            return s;
        }

        private static string InvokeStringMethodParam(string typeName, string methodName, string methodParam)
        {
            Type calledType = Type.GetType("Project365." + typeName);

            string s = (String)calledType.InvokeMember(methodName, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, new Object[] { methodParam });

            return s;
        }
    }
}
