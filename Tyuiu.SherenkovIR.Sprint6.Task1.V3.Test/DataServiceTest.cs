using Tyuiu.SherenkovIR.Sprint6.Task1.V3.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task1.V3.Test
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
            double[] waitMas = new double[len];
            waitMas[0] = 19.81;
            waitMas[1] = 16.79;
            waitMas[2] = 13.87;
            waitMas[3] = 10.98;
            waitMas[4] = 7.94;
            waitMas[5] = 3.00;
            waitMas[6] = 3.23;
            waitMas[7] = -0.45;
            waitMas[8] = -3.79;
            waitMas[9] = -6.97;
            waitMas[10] = -10.00;

            var res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(waitMas, res);
        }
    }
}
