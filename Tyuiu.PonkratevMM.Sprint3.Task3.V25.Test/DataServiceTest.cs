using Tyuiu.PonkratevMM.Sprint3.Task3.V25.Lib;
namespace Tyuiu.PonkratevMM.Sprint3.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string value = "kjhgfuu gujut dtuu";
            char chr = 'u';
            int res = ds.GetMinCharCount(value, chr);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}