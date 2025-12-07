using Tyuiu.SherenkovIR.Sprint6.Task2.V6.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait = new double[len];

            wait[0] = -55.58;
            wait[1] = 38.47;
            wait[2] = 7.35;
            wait[3] = 23.98;
            wait[4] = 11.78;
            wait[5] = 0.57;
            wait[6] = -6.30;
            wait[7] = -20.14;
            wait[8] = -3.51;
            wait[9] = 38.13;
            wait[10] = 59.60;

            var res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(wait[10], res[10]);
        }
    }
}
