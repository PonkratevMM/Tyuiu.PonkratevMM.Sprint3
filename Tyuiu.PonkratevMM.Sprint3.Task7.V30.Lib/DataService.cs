using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PonkratevMM.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 2;
                double value;

                if (denominator == 0 || double.IsInfinity(denominator))
                {
                    value = 0;
                }
                else
                {
                    value = (5 * x + 2.5) / denominator + 2 * x + 2;
                }

                values[index] = Math.Round(value, 2);
                index++;
            }

            return values;
        }
    }
}
