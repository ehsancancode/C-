using System;
namespace FitnessApp
{
    public class DietRecommender
    {
        public static void RecommendDiet(int goal, double targetWeight)
        {
            double calories = 0;
            double proteinPercent = 0;
            double carbPercent = 0;
            double fatPercent = 0;
            // calories and macros ratio
            if (goal == 1)
            {
                calories = targetWeight * 22;
                proteinPercent = 0.40;
                carbPercent = 0.30;
                fatPercent  = 0.30;
            }
            
            else if (goal == 2)
            {
                calories = targetWeight * 35;
                proteinPercent = 0.25;
                carbPercent = 0.50;
                fatPercent  = 0.25;
            }
            else if (goal == 3)
            {
                calories = targetWeight * 30;
                proteinPercent = 0.30;
                carbPercent = 0.40;
                fatPercent  = 0.30;
            }
            // calories to gram conversion logic
            double proteinGrams = (calories * proteinPercent) / 4;
            double carbGrams = (calories * carbPercent) / 4;
            double fatGrams = (calories * fatPercent) / 9;
            
            Console.WriteLine();
            Console.WriteLine("Daily Target: ");
            Console.WriteLine("Calories: " + calories + " kCal");
            Console.WriteLine("Protein: " + proteinGrams + " grams");
            Console.WriteLine("CARBS: " + carbGrams + " grams");
            Console.WriteLine("Fats: " + fatGrams + " grams");
            Console.WriteLine();
            Console.WriteLine("Pro Tip: Divide your Macros over 5 to 6 meals a day!");
        }
    }
}