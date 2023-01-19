// Author: Selassie Kwame Esiape
// Dice rolling game with C#
using System;

namespace SelassieEsiape_Mission_Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            int[] totals = new int[13]; // Create array to keep track of each total roll

            int rolls; // Declare variable to track number of times the dice will be thrown

            Random r = new Random(); // Create random number generator

            Console.Write("\nHow many dice rolls would you like to simulate? \n");

            //Take Input from user and store it into variable
            rolls = int.Parse(Console.ReadLine());

            // simulate rolling the dice
            for (int i = 0; i < rolls; i++)
            {
                int firstDie = r.Next(1, 7);
                int secondDie = r.Next(1, 7);
                // Sum up the dice results
                int total = firstDie + secondDie;
                // Increment in array position
                totals[total]++;
            }
            // print histogram
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");

            Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.");

            Console.WriteLine("Total number of rolls = " + rolls + "\n");

            //For loop to print histogram
            for (int i = 2; i <= 12; i++)
            {
                // Calculate percentages by dividing each element in array
                // by number of rolls and multiplying it by 100
                int percent = (int)(((double)totals[i] / rolls) * 100);

                Console.Write(i + ": ");

                //For loop to print * character
                for (int b = 0; b < percent; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator.  Goodbye!");
        }
    }
}
