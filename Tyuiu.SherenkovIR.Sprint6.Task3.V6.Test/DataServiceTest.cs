using Tyuiu.SherenkovIR.Sprint6.Task3.V6.Lib;
namespace Tyuiu.SherenkovIR.Sprint6.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { -2, - 10, - 8, 1, 11}, { -15, - 9, - 4, - 15, 18}, { -15, 12, 7, 6, 9 }, { -14, - 10,  10,  18, - 5 }, { -1, 7, - 19, - 19, - 4 } };
            int[,] res = ds.Calculate(array);
            int[,] wait = { { -2, -10, -8, 1, 11 }, { -15, -9, -4, -15, 18 }, { -15, 0, 7, 0, 9 }, { -14, -10, 10, 18, -5 }, { -1, 7, -19, -19, -4 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
