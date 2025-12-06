using Tyuiu.SherenkovIR.Sprint6.Task0.V16.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 3.111;
            Assert.AreEqual(res, wait);
        }
    }
}
