using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            var firstWords = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        if (words.Length > 0)
                        {
                            firstWords.Add(words[0]);
                        }
                    }
                }
            }

            return string.Join(" ", firstWords);
        }
    }
}
