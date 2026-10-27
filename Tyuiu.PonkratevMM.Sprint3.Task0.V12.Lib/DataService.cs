using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PonkratevMM.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow(value, i) + 1.0 / (i + 1.0);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
