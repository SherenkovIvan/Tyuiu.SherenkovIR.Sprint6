using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string file = File.ReadAllText(path);
            string[] strings = file.Split(" ");
            string res = "";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Contains("Строка"))
                {
                    res += $"{strings[i]} ";
                }

            }
            return res.Trim();
        }
    }
}
