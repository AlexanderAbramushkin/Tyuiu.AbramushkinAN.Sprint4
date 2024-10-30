using Tyuiu.AbramushkinAN.Sprint4.Task7.V30.Lib;

namespace Tyuiu.AbramushkinAN.Sprint4.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"684259137159648\". Преобразуйте её    *");
            Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "684259137159648";
          
            int RowsOfArray = 5;
            int ColumnsOfArray = 3;
            int index = 0;

            Console.WriteLine("Массив:");
            for (int i = 0; i < RowsOfArray; i++)
            {
                for (int j = 0; j < ColumnsOfArray; j++)
                {
                    Console.Write($"{value[index]}  ");
                    index++;
                }
                Console.WriteLine();
            }


            Console.WriteLine();


            int Result = ds.Calculate(RowsOfArray,ColumnsOfArray,value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($" Произведение чётных чисел массива = {Result}");
        }
    }
}
