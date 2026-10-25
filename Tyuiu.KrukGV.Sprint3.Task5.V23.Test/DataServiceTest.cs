
using Tyuiu.KrukGV.Sprint3.Task5.V23.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 10);
            
            Assert.AreEqual(-3653.176, res);
        }
    }
}
