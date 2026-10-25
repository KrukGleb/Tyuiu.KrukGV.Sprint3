
using Tyuiu.KrukGV.Sprint3.Task7.V6.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] ans = { 23.917, 18.876,  13.096,  7.238,   1.798,   -8.000,  -5.695,  -11.257, -17.117, -22.883, -27.915};

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
