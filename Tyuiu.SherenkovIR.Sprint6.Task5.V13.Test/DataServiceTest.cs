using Tyuiu.SherenkovIR.Sprint6.Task5.V13.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask5V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask5V13.txt";
            var res = ds.LoadFromDataFile(path);
            double[] wait = { -1, -1, -3, 8,-5, -8,-6.63, 7,4.83, 3.26, -8.03, -4.59};
            Assert.AreEqual(wait, res);
        }
    }
}
