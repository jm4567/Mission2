namespace Mission2;

using System;

public class StimulateDice
{
    public int[] Roll(int diceRolls)
    {
        // Array to store the frequency of each sum (2-12)
        int[] rolls = new int[11]; 
        Random random = new Random(); //creating a new random variable 

        // Simulate rolling two dice
        for (int i = 0; i < diceRolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll die 1 (1-6)
            int die2 = random.Next(1, 7); // Roll die 2 (1-6)
            int sum = die1 + die2;        // Calculate the sum of the two dice

            rolls[sum - 2]++; // Increment the frequency for this sum (sum needs to map with the index of the array)
            
            //example of sum mapping with the index of the array
            //rolls[0] (for sum 2) = 0
            // rolls[1] (for sum 3) = 0
            // rolls[2] (for sum 4) = 1
            // rolls[3] (for sum 5) = 1
            // rolls[4] (for sum 6) = 0
            // rolls[5] (for sum 7) = 1
            // rolls[6] (for sum 8) = 1
            // rolls[7] (for sum 9) = 1
            // rolls[8] (for sum 10) = 0
            // rolls[9] (for sum 11) = 0
            // rolls[10] (for sum 12) = 0
        }

        //returning rolls so this array can be accessed in the First class
        return rolls;
    }
}
