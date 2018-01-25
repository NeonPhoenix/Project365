using System;

namespace Project365.January
{
    class Day9
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Convert either decimal to binary or binary to decimal.");
            Console.Write("Do you want to convert to binary or decimal: ");
            string convert = Console.ReadLine();

            if(convert == "binary")
            {
                Console.Write("Number you want to convert: ");
                int inputNum = int.Parse(Console.ReadLine());

                string binary = Convert.ToString(inputNum, 2);

                Console.WriteLine("Binary equivelant of {0} is " + binary, inputNum);
            }
            else
            {
                Console.Write("Binary you want to convert: ");
                string inputString = Console.ReadLine();

                int outputNum = Convert.ToInt32(inputString, 2);

                Console.WriteLine("Decimal equivelant of " + inputString + " is {0}", outputNum);
            }

            Program.Restart(5000);
        }
    }
}
