using DiceGame;
// Preston Fitzgerald, 1-12
// This is the Mission 2 assignment. It simulates rolling two six-sided dice as many times as the user wants. It then prints a histogram for results
internal class Program
{
    private static void Main(string[] args)
    {
        // initialize classes and variables
        DieThrow dt = new DieThrow();
        int throws;
        int[] results;

        // make it look like the program is starting
        Console.WriteLine("Welcome to Preston's first C# project. In this project, we will roll two six-sided dice. \n\n");

        // get input
        Console.WriteLine("Please enter the number of times that you would like to roll the dice:");
        throws = Convert.ToInt32(Console.ReadLine());
            
        // Call function and get output
        results = dt.DiceThrow(throws);

        //Flavor text
        Console.WriteLine("\n\nDICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = " + throws + ".\r\n");
        
        // calculate and print percentages
        for (int i = 0; i < 11; i++)
        {
            string stars = "";
            int rolls = results[i];
            float rawPercent;
            rawPercent = ((float)rolls / throws) * 100;
            decimal Percent = Math.Round((decimal)rawPercent, 0, MidpointRounding.AwayFromZero);
            for (int i2 = 0; i2 < Percent; i2++)
            {
                stars = stars + "*";
            }
            // display histogram
            Console.WriteLine((i+2) + ": \t" + stars);
        }

        // more flavor text
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\r\n");
    }
}