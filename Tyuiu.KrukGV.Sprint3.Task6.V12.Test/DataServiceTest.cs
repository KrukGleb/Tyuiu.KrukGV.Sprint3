
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
            bool[] res = ds.GetCompareOperations(1065, 755);
            bool[] ans = { true, false, false, false, false, false };

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
