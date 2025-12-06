using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (int)(stopValue - startValue) + 1;
            double[] mass = new double[len];
            int count = 0;

            for (int i = (int)startValue; i <= stopValue; i++)
            {
                double y;
                double denominator = 2 * i - 0.5;

                if (Math.Abs(denominator) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    y = 5 - 3 * i + (1 + Math.Sin(i)) / denominator;
                    y = Math.Round(y, 2);
                }

                mass[count] = y;
                count++;
            }

            return mass;
        }
    }
}
