namespace FitnessApp
{
    public class BmiCalculator
    {
        public static double CalculateBmi(double weight, double heightInMeters)
        {
            return weight / (heightInMeters * heightInMeters);
        }
    }
}