using System;

namespace Comp5202_Problem2_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
         //Start the program with Clear();
         Console.Clear();
         //Program function
         Console.WriteLine("This Program will display division table 12 times for the number you enter");
         //Var homes
         //Ask user to input a number
         Console.WriteLine("Please enter a number that is below 100");
         //User input
         double num = Double.Parse (Console.ReadLine());
         //check if input is a number

         //If statement to check if number is under 100
         if (num <= 100)
         {
            for (var table = 0; table <= 12; table++)
            {
                Console.WriteLine(num/table); 
            }
         } else
            {
                Console.WriteLine($"The number {num} is over 100 Please try again");
            }
         //End the program with blank line and instructions
         Console.ResetColor();
         Console.WriteLine();
         Console.WriteLine("Please Press <Enter> to quit the program");
         Console.ReadKey();
        }
    }
}
