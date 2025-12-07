using Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            Assert.AreEqual(wait, res);
        }
    }
    
}
