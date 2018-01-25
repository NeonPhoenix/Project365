using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project365.January
{
    class Day7
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Calculate the monthly payments of a fixed term mortage over given Nth terms at a give interest rate.");

            Console.Write("How much is the Principle of the loan: ");
            double principle = double.Parse(Console.ReadLine());

            Console.Write("What is the percent of interest for the loan: ");
            double interest = double.Parse(Console.ReadLine());

            Console.Write("How long will the loan be: ");
            double length = double.Parse(Console.ReadLine());

            double intRate = (interest / 100) / 12;
            double intRateA = intRate + 1;
            double lengthMon = length * 12;
            double intPower = Math.Pow(intRateA, lengthMon);

            double equTop = intRate * intPower;
            double equBot = intPower - 1;
            double equTot = equTop / equBot;

            double monthlyPayments = principle * equTot;

            Console.WriteLine("Total monthly repayments for a mortage of ${0} is ${1} to be paid off in {2} months.", principle, Math.Round(monthlyPayments, 2, MidpointRounding.AwayFromZero), lengthMon);

            Program.Restart();
        }
    }
}
