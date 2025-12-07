using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SherenkovIR.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string file = File.ReadAllText(path);

            string[] words = file.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];
                if (i < words.Length - 1)
                {
                    result += " ";
                }
            }
           

            return result;
        }
    }
}
