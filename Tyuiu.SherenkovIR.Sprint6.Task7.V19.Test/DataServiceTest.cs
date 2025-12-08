using Tyuiu.SherenkovIR.Sprint6.Task7.V19.lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:DataSprint6\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
