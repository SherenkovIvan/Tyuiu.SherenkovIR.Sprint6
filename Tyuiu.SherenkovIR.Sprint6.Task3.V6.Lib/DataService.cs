using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task3.V6.Lib
{
    public class DataService : ISprint6Task3V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();
            int targetRow = 2;

            for (int j = 0; j < cols; j++)
            {
                if (result[targetRow, j] % 2 == 0)
                {
                    result[targetRow, j] = 0;
                }
            }

            return result;
        }
    }
}
