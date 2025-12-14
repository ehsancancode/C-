// Code Author: Ehsan Khan
// ehsan.khan@centria.fi
// Date: 10/12/2025

namespace FitnessApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fitness App");
            Console.WriteLine("--------------------------");

            // Get user data
            double weight = AskDouble("Enter your weight in kg: ");
            double height = AskDouble("Enter your height in meters: ");

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);
            Console.WriteLine("Your BMI is: " + bmi);

            // Ask for goal
            int goal = AskGoal();

            // Recommend diet
            RecommendDiet(goal);
        }
        
        public static double AskDouble(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        // Calculates BMI
        public static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        // user fitness goal
        public static int AskGoal()
        {
            Console.WriteLine();
            Console.WriteLine("Choose your fitness goal:");
            Console.WriteLine("1 - Weight Loss");
            Console.WriteLine("2 - Weight Gain");
            Console.WriteLine("3 - Build Lean Muscle Mass");

            int choice = 0;

            // loop until valid input
            while (choice < 1 || choice > 3)
            {
                Console.Write("Enter your choice (1-3): ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            return choice;
        }

        // Recommends macros based on goal
        public static void RecommendDiet(int goal)
        {
            Console.WriteLine();
            Console.WriteLine("Recommended Macros:");

            List<string> macros = new List<string>();

            if (goal == 1)
            {
                macros.Add("Protein: High");
                macros.Add("Carbohydrates: Low");
                macros.Add("Fats: Moderate");
            }
            else if (goal == 2)
            {
                macros.Add("Protein: Moderate");
                macros.Add("Carbohydrates: High");
                macros.Add("Fats: Moderate");
            }
            else if (goal == 3)
            {
                macros.Add("Protein: High");
                macros.Add("Carbohydrates: Moderate");
                macros.Add("Fats: Low");
            }

            // Print all macros from the list
            foreach (string macro in macros)
            {
                Console.WriteLine(macro);
            }
        }
    }
}
