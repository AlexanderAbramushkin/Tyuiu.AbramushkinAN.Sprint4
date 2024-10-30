using Tyuiu.AbramushkinAN.Sprint4.Task4.V11.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 5 до 8. Найдите сумму нечётных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("*                               5, 7, 7, 8, 5,                            *");
            Console.WriteLine("*                               6, 5, 6, 8, 6,                            *");
            Console.WriteLine("*                               7, 6, 8, 8, 5,                            *");
            Console.WriteLine("*                               7, 6, 7, 8, 6,                            *");
            Console.WriteLine("*                               7, 6, 7, 7, 5                             *");
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
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine();


            int Result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($" Минимальный элемент в первом столбце массива = {Result}");
        }
    }
}
