using System;
using static System.Console;

namespace SearchArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] customers = { "Belgarath", "Frodo", "Richard", "Peter", "Alanna" };
            double[] checking = { -30.50, 50, 20_000_000, 10_000, 523_456 };
            double[] savings = { 10_546.99, 5_123, 34, 550, 67 };

            bool found = false;
            int foundPosition = 0;

            WriteLine("Please enter name");
            string input = ReadLine();

            for(int x = 0; x < customers.Length;++x)
            {
                if(input == customers[x])
                {
                    foundPosition = x;
                    found = true;
                    x = customers.Length; //exit the loop
                }
            }

            if(found)
            {
                WriteLine("Customer {0} has {1:C} in checking and {2:C} in savings",
                    customers[foundPosition], checking[foundPosition], savings[foundPosition]);
            }
            else
            {
                WriteLine("No such name exists");
            }
            
        }
    }
}
