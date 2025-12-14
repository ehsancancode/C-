// Code Author: Ehsan Khan
// ehsan.khan@centria.fi
// Date: 10/12/2025
using System;
namespace FitnessApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fitness App");
            Console.WriteLine("--------------------------");

            // Get user data
            Console.WriteLine("Enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height in centimeters: ");
            double height = double.Parse(Console.ReadLine());

            // Calculate BMI
            double bmi = BmiCalculator.CalculateBmi(weight, height);
            Console.WriteLine("Your BMI is: " + bmi);

            // Ask for goal
            int goal = UserInput.Goal();

            // Recommend diet
            DietRecommender.RecommendDiet(goal);
        }
    }
}
