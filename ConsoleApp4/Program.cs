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
            //Though I asked for the height in cm's but BMI mathematical formula needs
            //meters so that why we need the conversion below before passing the
            //arguments to the CalculateBmi Function
            double heightInMeters = height / 100;
            // Calculate BMI
            double bmi = BmiCalculator.CalculateBmi(weight, heightInMeters);
            Console.WriteLine("Your BMI is: " + bmi);

            // Ask for goal
            int goal = UserInput.Goal();
            // user's target weight
            double targetWeight;
            Console.WriteLine("Enter your target weight (kg): ");
            targetWeight = double.Parse(Console.ReadLine());

            // Recommend diet
            DietRecommender.RecommendDiet(goal, targetWeight);
        }
    }
}
