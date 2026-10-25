
using Tyuiu.KrukGV.Sprint3.Task6.V12.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(9, 18);


            Assert.AreEqual(221, res);
        }
    }
}
