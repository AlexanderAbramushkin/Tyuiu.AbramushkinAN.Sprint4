using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int Result = 1;

            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());
                    if (matrix[i, j] % 2 == 0)
                    {
                        Result*=matrix[i, j];
                    }

                }   
            }
            return Result;
        }
    }
}
