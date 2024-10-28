using Tyuiu.AbramushkinAN.Sprint4.Task1.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 7 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 2, 4, 4, 7, 2, 5, 4, 3, 3, 4   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int LenOfArray;
            Console.WriteLine("Введите количество элементов массива: ");
            LenOfArray = Convert.ToInt32(Console.ReadLine());

            int[] NumsOfArray = new int[LenOfArray];

            for (int i = 0; i < LenOfArray; i++) 
            {
                Console.WriteLine($"Введите значение {i} элемента массива: ");
                NumsOfArray[i]  = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine($"Исходный массив: ");
            for (int i = 0; i < NumsOfArray.Length; i++)
            {
                Console.WriteLine(NumsOfArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            int Result = ds.Calculate(NumsOfArray);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение чётных элементов массива = {Result}");
        }
    }
}
