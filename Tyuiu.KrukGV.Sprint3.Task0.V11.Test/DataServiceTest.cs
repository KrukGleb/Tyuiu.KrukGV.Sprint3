
using Tyuiu.KrukGV.Sprint3.Task0.V11.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSeries(5, 1, 10);
            

            Assert.AreEqual(0.04166666666666623, res);
        }
    }
}
