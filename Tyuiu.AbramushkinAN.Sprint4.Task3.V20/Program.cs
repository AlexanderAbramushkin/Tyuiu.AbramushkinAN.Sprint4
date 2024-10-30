using Tyuiu.AbramushkinAN.Sprint4.Task3.V20.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task3.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите минимальный      *");
            Console.WriteLine("* элемент в первом столбце массива.                                       *");
            Console.WriteLine("*                               8, 7, 7, 8, 5,                            *");
            Console.WriteLine("*                               4, 3, 5, 3, 6,                            *");
            Console.WriteLine("*                               5, 3, 8, 6, 3,                            *");
            Console.WriteLine("*                               6, 3, 8, 5, 4,                            *");
            Console.WriteLine("*                               3, 6, 8, 3, 4                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5] { {8,7,7,8,5},
                                            {4,3,5,3,6},
                                            {5,3,8,6,3},
                                            {6,3,8,5,4},
                                            {3,6,8,3,4} };
            int RowsOfArray = matrix.GetUpperBound(0)+1;
            int ColumnsOfArray = matrix.GetUpperBound(1)+1;


            int result = ds.Calculate(matrix);
            Console.WriteLine("Массив:");
            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
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
