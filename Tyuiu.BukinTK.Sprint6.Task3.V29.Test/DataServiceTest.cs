using Tyuiu.BukinTK.Sprint6.Task3.V29.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {-2, -13, -15, -9, -17},
                {13, -20, -15, 27, 18},
                {-12, -1, -20, 13, 0},
                {15, 32, 18, -12, -18},
                {16, 5, 3, -5, -8}
            };

            int[,] result = ds.Calculate(matrix);


            Assert.AreEqual(-12, result[0, 3]);
            Assert.AreEqual(4, result[1, 3]);
            Assert.AreEqual(23, result[2, 3]);
            Assert.AreEqual(21, result[3, 3]);
            Assert.AreEqual(13, result[4, 3]);
        }
    }
}
