
using System;
// create a class to collect input from the user, how many dice they want to roll
class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // Allow the user to input the number of rolls
        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        // Create an instance of the DiceRoller class
        DiceRoller diceRoller = new DiceRoller();

        // Simulate the roll of two dice and get the results
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        // Print the histogram based on the results from the other class
        PrintHistogram(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    // defines a method that takes an array of the results
    // and total numer of rolls as parameters
    // and outputs the results 
    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        // display the correct ammount of asterisks
        // according to every dice roll sum
        for (int i = 2; i <= 12; i++)
        {
            // shows the occurrences for the current sum of the two dice
            int percentage = results[i - 2] * 100 / totalRolls;
            // creates a string of asterisks for the sum
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }
    }
}
