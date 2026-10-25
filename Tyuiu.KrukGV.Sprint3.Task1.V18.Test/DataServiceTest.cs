
using Tyuiu.KrukGV.Sprint3.Task1.V18.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(1, 15);
            

            Assert.AreEqual(0.121, res);
        }
    }
}
