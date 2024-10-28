using Tyuiu.AbramushkinAN.Sprint4.Task2.V10.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 6 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
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
                NumsOfArray[i] = rnd.Next(1, 7);
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

            Console.WriteLine($"Произведение нечётных элементов массива = {Result}");
        }
    }
}
