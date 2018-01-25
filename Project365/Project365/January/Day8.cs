using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project365.January
{
    class Day8
    {
        public static void main()
        {
            Console.Clear();

            Console.WriteLine("Calculate the change to be given back. Total number of coins will be also given.");
            Console.Write("How much for the product: $");
            double total = double.Parse(Console.ReadLine());

            Console.Write("Total amount given: $");
            double givenChange = double.Parse(Console.ReadLine());

            double dueChange = Math.Round(givenChange - total, 2, MidpointRounding.AwayFromZero);
            string currency = dueChange.ToString();

            Console.WriteLine("Change to be given for {0} is {1}. Exact number of coins and notes to be given are " + GetChangeString(currency), givenChange, dueChange);

            Program.Restart(5000);
        }

        private static string GetChangeString(string currency)
        {
            int[] amounts = { 50 * 100, 20 * 100, 10 * 100, 5 * 100, 1 * 100, 25, 10, 5, 1 };
            string[] txt = { "Fifty", "Twenty", "Ten", "Five", "One", "Quarter", "Dime", "Nickel", "Penny" };

            int cents = (int)(double.Parse(currency) * 100);
            string formattedChange = "";

            for(int i = 0; i < amounts.Length; i++)
            {
                int amount = amounts[i];
                int amountItems = cents / amount;

                if(amountItems > 0)
                {
                    formattedChange += amountItems + " " + txt[i] + "(s), ";
                    cents -= (amountItems * amount);
                }
            }

            return formattedChange;
        }
    }
}
