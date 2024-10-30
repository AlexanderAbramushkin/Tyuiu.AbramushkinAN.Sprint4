using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task4.V11.Lib
{
    public class DataService : ISprint4Task4V11
    {
        public int Calculate(int[,] matrix)
        {
            int Result = 0;
            int RowsOfArray = matrix.GetUpperBound(0)+1;
            int ColumnsOfArray = matrix.GetUpperBound(1)+1;

            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        Result += matrix[i, j];
                    }
                }
            }

            return Result;
        }
    }
}
