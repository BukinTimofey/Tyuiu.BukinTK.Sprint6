using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BukinTK.Sprint6.Task7.V9.Lib
{
    public class DataService : ISprint6Task7V9
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j]);
                }
            }
            return matrix;
        }

        public int[,] ProcessMatrix(int[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int[,] result = (int[,])data.Clone();

            int targetColumn = cols - 4;

            for (int i = 0; i < rows; i++)
            {
                if (result[i, targetColumn] >= 1 && result[i, targetColumn] <= 5)
                    result[i, targetColumn] = 7;
            }

            return result;
        }

        public void SaveToFile(string path, int[,] matrix)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    string line = "";
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        line += matrix[i, j].ToString();
                        if (j < matrix.GetLength(1) - 1)
                            line += ";";
                    }
                    sw.WriteLine(line);
                }
            }
        }
    }
}