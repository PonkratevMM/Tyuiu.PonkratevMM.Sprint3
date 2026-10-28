using Tyuiu.PonkratevMM.Sprint3.Task7.V30.Lib;
namespace Tyuiu.PonkratevMM.Sprint3.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = new double[11];

            for (int x = startValue, i = 0; x <= stopValue; x++, i++)
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

                wait[i] = Math.Round(value, 2);
            }

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
