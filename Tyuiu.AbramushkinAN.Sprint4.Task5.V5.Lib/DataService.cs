using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task5.V5.Lib
{
    public class DataService : ISprint4Task5V5
    {
        public int Calculate(int[,] matrix)
        {
            int RowsOfArray = matrix.GetUpperBound(0)+1;
            int ColumnsOfArray = matrix.GetUpperBound(1)+1;
            int Result = 0;

            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        Result += matrix[i, j];
                    }
                }
            }

            return Result;

        }
    }
}
