using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PonkratevMM.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char chr)
        {
            int minCount = int.MaxValue;
            int currentCount = 0;
            int totalCount = 0;

            foreach (char c in value)
            {
                if (c == chr)
                {
                    currentCount++;
                    totalCount++;
                }
                else
                {
                    if (currentCount > 0)
                    {
                        if (currentCount < minCount)
                        {
                            minCount = currentCount;
                        }
                        currentCount = 0;
                    }
                }
            }

            if (currentCount > 0)
            {
                if (currentCount < minCount)
                {
                    minCount = currentCount;
                }
            }

            if (totalCount == 0)
            {
                return 0;
            }

            return minCount;
        }
    }
}