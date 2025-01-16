// See https://aka.ms/new-console-template for more information

namespace Mission2;
using System; 
internal class Program
{
    public static void Main(string[] args)
    {
        //create an instance 
        StimulateDice sd = new StimulateDice();
        
        //initializing dice rolls 
        int diceRolls = 0;
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        
        //getting the input for how many times to roll the dice 
        Console.WriteLine("How many dice rolls would you like to simulate?");
        diceRolls = Convert.ToInt32(Console.ReadLine());
        
        //calling the method from the simulate dice amd storing it in an array 
        //returns dice roll array to first class and creating it in the second class 
        int[] rolls = sd.Roll(diceRolls); 
        
        PrintResult(rolls, diceRolls); //calling to print stuff 
        
       Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    private static void PrintResult(int[] rolls, int totalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS" + "\n");
        Console.WriteLine("Each * represents 1% of the total number of rolls." + "\n");                
        Console.WriteLine($"Total number of rolls: {totalRolls}\n");
        
        for (int i = 0; i < rolls.Length; i++) //iterating through the array to print results 
        {
            int sum = i + 2; // Map index to sum (2-12)
            int percentage = (rolls[i] * 100 / totalRolls); //calculating the percent from the array values
            int stars = (percentage); // Each '*' represents 1%
            
            Console.WriteLine($"{sum,2}: {new string('*', stars)}"); //showing the results 
        }
    }
    
}