using Tyuiu.SherenkovIR.Sprint6.Task4.V9.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task4.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] waitArray = new double[len];

            waitArray[0] = -25.31;
            waitArray[1] = -20.82;
            waitArray[2] = -16.32;
            waitArray[3] = -12.31;
            waitArray[4] = -8.85;
            waitArray[5] = -3.00;
            waitArray[6] = 4.84;
            waitArray[7] = 11.11;
            waitArray[8] = 17.84;
            waitArray[9] = 24.93;
            waitArray[10] = 25.24;

            var resArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(resArray, waitArray);
        }
    }
}
