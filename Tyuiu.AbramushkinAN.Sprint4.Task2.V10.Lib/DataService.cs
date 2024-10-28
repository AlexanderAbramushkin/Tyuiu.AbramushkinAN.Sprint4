using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task2.V10.Lib
{
    public class DataService : ISprint4Task2V10
    {
        public int Calculate(int[] array)
        {
            int Result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Result *= array[i];
                }
            }
            return Result;
        }
    }
}
