using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int RowsOfArray = array.GetUpperBound(0) + 1;
            int ColumnsOfArray = array.Length / RowsOfArray;
            int Result = int.MaxValue;

            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    if (j == 0 && array[i, j] < Result)
                    {
                        Result = array[i, j];
                    }
                }
            }
            return Result;
        }
    }
}
