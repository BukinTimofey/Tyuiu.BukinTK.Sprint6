using Tyuiu.BukinTK.Sprint6.Task0.V14.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(-0.444, res);
        }
    }
}
