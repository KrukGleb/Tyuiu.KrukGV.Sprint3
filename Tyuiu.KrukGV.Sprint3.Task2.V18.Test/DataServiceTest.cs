
using Tyuiu.KrukGV.Sprint3.Task2.V18.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(1, 1, 14);
            

            Assert.AreEqual(287.18, res);
        }
    }
}
