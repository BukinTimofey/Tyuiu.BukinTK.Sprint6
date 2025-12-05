using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BukinTK.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            {
                int len = stopValue - startValue + 1;
                double[] result = new double[len];
                int index = 0;

                for (int x = startValue; x <= stopValue; x++)
                {
                    double fx = 0.0;

                    double denominator = 2;

                    if (denominator == 0)
                    {
                        fx = 0.0;
                    }
                    else
                    {
                        fx = Math.Cos(x) + (4 * x) / denominator - Math.Sin(x) * 3 * x;
                    }

                    fx = Math.Round(fx, 2);
                    result[index] = fx;
                    index++;
                }

                return result;
            }
        }
    }
}
