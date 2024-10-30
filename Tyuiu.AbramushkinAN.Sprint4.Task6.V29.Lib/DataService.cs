using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AbramushkinAN.Sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(len => len.Length > 4);
            return count;
        }
    }
}
