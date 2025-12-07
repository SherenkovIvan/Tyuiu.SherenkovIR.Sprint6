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
            var resArray = ds.LoadFromDataFile(path);
            double[] waitArray = new double[resArray.Length];
            waitArray[0] = -13.0;
            waitArray[1] = -19.0;
            waitArray[2] = -9.82;
            waitArray[3] = -9.71;
            waitArray[4] = 3.36;
            waitArray[5] = 0.48;
            waitArray[6] = 4.13;
            waitArray[7] = -0.11;
            waitArray[8] = -17.36;
            waitArray[9] = -12.00;
            waitArray[10] = -12.35;


            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
        

