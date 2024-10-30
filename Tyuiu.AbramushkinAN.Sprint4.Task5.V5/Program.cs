using Tyuiu.AbramushkinAN.Sprint4.Task5.V5.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 5 до -8. Найдите сумму             *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int RowsOfArray = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int ColumnsOfArray = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[RowsOfArray, ColumnsOfArray];


            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    matrix[i, j] = rnd.Next(-5,9);
                }
            }

            Console.WriteLine("Массив: ");

            for (int i = 0;i < RowsOfArray; i++)
            {
                for(int j = 0;j < ColumnsOfArray; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            int Result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($" Сумма положительных элементов массива = {Result}");
        }
    }
}
