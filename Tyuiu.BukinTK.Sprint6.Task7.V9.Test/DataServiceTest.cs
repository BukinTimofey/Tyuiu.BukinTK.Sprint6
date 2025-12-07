using Tyuiu.BukinTK.Sprint6.Task7.V9.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidProcessMatrix()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName().Replace(".tmp", ".csv");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
