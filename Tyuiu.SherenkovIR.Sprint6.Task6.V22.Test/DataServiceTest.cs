using Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V22.txt";
            string res = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            string wait = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, wait);
        }
    }
    
}
