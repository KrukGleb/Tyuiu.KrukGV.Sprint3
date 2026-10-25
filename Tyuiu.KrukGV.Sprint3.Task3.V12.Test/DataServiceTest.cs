
using Tyuiu.KrukGV.Sprint3.Task3.V12.Lib;

namespace Tyuiu.KrukGV.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int res = ds.GetMaxCharCount("bkkrk ckkkcs ksr", 'k');
            

            Assert.AreEqual(3, res);
        }
    }
}
