using Tyuiu.PlesovskikhBA.Sprint3.Task0.V5.Lib;
namespace Tyuiu.PlesovskikhBA.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 55.669;
            Assert.AreEqual(wait, res);
        }
    }
}