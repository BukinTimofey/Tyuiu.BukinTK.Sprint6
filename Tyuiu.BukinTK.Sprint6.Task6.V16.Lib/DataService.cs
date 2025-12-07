using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BukinTK.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            try
            {
                string result = "";

                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("Файл не найден", path);
                }

                string text = File.ReadAllText(path);
                char[] separators = new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '"', '(', ')', '[', ']', '{', '}' };
                string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                List<string> wordsWithB = new List<string>();

                foreach (string word in words)
                {
                    if (word.Contains('b'))
                    {
                        wordsWithB.Add(word);
                    }
                }

                return string.Join(" ", wordsWithB);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при обработке файла: " + ex.Message);
            }
        }
    }
}
