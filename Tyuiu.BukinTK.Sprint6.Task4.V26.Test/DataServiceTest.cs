using Tyuiu.BukinTK.Sprint6.Task4.V26.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Assert.IsNotNull(result);
            Assert.AreEqual(11, result.Length);
        }
    }
}
