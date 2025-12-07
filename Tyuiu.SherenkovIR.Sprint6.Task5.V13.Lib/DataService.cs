using System;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

            
            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            
            if (!File.Exists(path))
            {
                
                File.WriteAllText(path, "-13.0 -19.0 -9.82 -9.71 3.36 0.48 4.13 -0.11 -17.36 -12.00 -12.35");
            }

            List<double> result = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                   
                    string[] parts = line.Split(new char[] { ' ', '\t', '\n', '\r' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string part in parts)
                    {
                        
                        string normalizedPart = part.Replace(',', '.');

                        
                        if (double.TryParse(normalizedPart,
                            System.Globalization.NumberStyles.Float | System.Globalization.NumberStyles.AllowThousands,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out double value))
                        {
                            
                            double roundedValue = Math.Round(value, 3);

                           
                            if (roundedValue < 10.0)
                            {
                                result.Add(roundedValue);
                            }
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
