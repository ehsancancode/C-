using System;
namespace FitnessApp
{
    public class DietRecommender
    {
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

            foreach (string macro in macros)
            {
                Console.WriteLine(macro);
            }
        }
    }
}