using Tyuiu.BukinTK.Sprint6.Task6.V16.Lib;

namespace Tyuiu.BukinTK.Sprint6.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            try
            {
                string testData = "-+-";
                File.WriteAllText(path, testData);

                string wait = "--";
                string res = ds.CollectTextFromFile(path);

                Assert.AreEqual(wait, res);
            }
            finally
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
    }
}
