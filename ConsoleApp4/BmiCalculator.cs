namespace FitnessApp
{
    public class BmiCalculator
    {
        public static double CalculateBmi(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}