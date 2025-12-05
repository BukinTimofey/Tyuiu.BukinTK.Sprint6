using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BukinTK.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int[] column5 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                column5[i] = matrix[i, 4];
            }

            Array.Sort(column5);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = column5[i];
            }
            return matrix;
        }
    }
}
