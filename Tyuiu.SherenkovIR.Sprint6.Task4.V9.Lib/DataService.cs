using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task4.V9.Lib
{
    public class DataService : ISprint6Task4V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mas = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) - 2 * x == 0)
                {
                    mas[index++] = 0;
                }
                else
                {
                    mas[index++] = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
                    
                }
            }

            return mas;
        }
    }
}
