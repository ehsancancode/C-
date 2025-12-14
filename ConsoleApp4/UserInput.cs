using System;
namespace FitnessApp
{
    public class UserInput
    {
        public static int Goal()
        {
            Console.WriteLine();
            Console.WriteLine("Choose your fitness goal:");
            Console.WriteLine("1 - Weight Loss");
            Console.WriteLine("2 - Weight Gain");
            Console.WriteLine("3 - Build Lean Muscle Mass");

            int choice = 0;

            while (choice < 1 || choice > 3)
            {
                Console.Write("Enter your choice (1-3): ");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
    }
}