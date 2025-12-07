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

            if (cols < 3)
            {
                return (int[,])data.Clone();
            }

            int[,] result = (int[,])data.Clone();
            int targetColumn = 2;

            for (int i = 0; i < rows; i++)
            {
                int value = result[i, targetColumn];
                if (value >= 1 && value <= 5)
                {
                    result[i, targetColumn] = 7;
                }
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

//[[16, -15, -14, -16, -9, -10, -17, 12, -20, -12],
//[7, 20, -16, 13, 19, 15, -13, -4, 9, 18],
//[-4,18,8,9,-3,14,-17,18,-12,-11],
//[-13,5,7,-13,2,-9,19,19,-16,1],
//[12, 7, 7, -6, 11, -7, 17, -8, -11, -4],
//[-8,-16,-13,-16,3,-3,-13,20,-15,6],
//[11, 18, -17, -5, -14, 18, 5, 9, -4, -17],
//[6, 9, 18, 14, 15, -4, 3, -7, -18, 14],
//[3, 5, 11, 15, -17, 8, 9, -1, 11, 19],
//[11, -20, 17, 12, 16, 13, -15, 3, 16, 7]]

//[[16, -15, -14, -16, -9, -10, -17, 12, -20, -12],
//[7, 20, -16, 13, 19, 15, -13, -4, 9, 18],
//[-4,18,8,9,-3,14,-17,18,-12,-11],
//[-13,5,2,-13,2,-9,19,19,-16,1],
//[12, 7, 5, -6, 11, -7, 17, -8, -11, -4],
//[-8,-16,-13,-16,3,-3,-13,20,-15,6],
//[11, 18, -17, -5, -14, 18, 5, 9, -4, -17],
//[6, 9, 18, 14, 15, -4, 3, -7, -18, 14],
//[3, 5, 11, 15, -17, 8, 9, -1, 11, 19],
//[11, -20, 17, 12, 16, 13, -15, 3, 16, 7]]