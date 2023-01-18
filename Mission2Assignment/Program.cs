//Spencer Kimball
//Mission 2
//Dice Simulation
using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate new instances of random classes
            Random rand1 = new Random();
            Random rand2 = new Random();

            //Create array
            int[] array = new int[13];

            //set each item in array equal to 0
            for (int i = 0; i < 13; i++)
            {
                array[i] = 0;
            }

            //Declare numRolls variable
            string numRolls = "";

            //Write text and allow user to respond with # of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            numRolls = Console.ReadLine();
            
            //Convert user input to integer
            int numVal = 0;
            numVal = Convert.ToInt32(numRolls);

            //For the user's # of rolls, generate two random numbers between 1 and 6
            //Add the numbers together and keep track of each time the total was rolled in an array
            for (int i = 0; i < numVal; i++)
            {
                int roll = rand1.Next(1,7);
                int roll2 = rand2.Next(1,7);

                int total = roll + roll2;

                array[total]++;
            }

            //Explain results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\n" +
                "Each \"*\" represents 1% of the total number of rolls.\n" +
                "Total number of rolls = " + numVal + ".\n");

            //For each item in the array, add 1 asterisk for every 1%
            int[] array2 = new int[13];
            for (int i1 = 2; i1 < 13; i1++)
            {
                float percentage = (((float)array[i1] / (float)numVal) * 100);
                string asterisk = "";

                for (int i = 0; i < percentage; i++)
                {
                    asterisk += "*";
                }

                Console.WriteLine(i1 + ": " + asterisk);
            }

            //Thank you message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
