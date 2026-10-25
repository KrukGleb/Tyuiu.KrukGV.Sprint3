
using Tyuiu.KrukGV.Sprint3.Task4.V15.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);

            Assert.AreEqual(623.499, res);
        }
    }
}
