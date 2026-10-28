using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PonkratevMM.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for ( i = startValue1;  i <= stopValue1; i++ )
            {
                for ( j = startValue2; j <= stopValue2; j++ )
                {
                    sumSeries += (Math.Pow(x, startValue1) + Math.Sin(startValue1)); 
                }
            }
            return Math.Round(sumSeries,3);

            
        }
    }
}
