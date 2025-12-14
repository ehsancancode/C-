namespace FitnessApp
{
    public class BmiCalculator
    {
        public static double CalculateBmi(double weight, double heightInCm)
        {
            double heightInMeters = heightInCm / 100;
            return weight / (heightInMeters * heightInMeters);
        }
    }
}