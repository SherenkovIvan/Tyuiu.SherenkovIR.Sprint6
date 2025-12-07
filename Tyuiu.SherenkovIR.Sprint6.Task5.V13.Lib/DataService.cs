using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);

            string[] parts = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> result = new List<double>();

            foreach (string part in parts)
            {
                if (double.TryParse(part,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out double value))
                {
                    double roundedValue = Math.Round(value, 3);

                    if (roundedValue < 10)
                    {
                        result.Add(roundedValue);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
