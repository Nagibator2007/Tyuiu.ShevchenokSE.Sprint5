using Tyuiu.ShevchenokSE.Sprint5.Task2.V8.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл.      ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #15                                                              ");
            Console.WriteLine("* Выполнил: Шевченок Сергей Евгеньевич |  СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("  Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями");
            Console.WriteLine("*с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0.");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.     ");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { -9, 4, -6 }, { 3, 9, 9 }, { -6, 7, 4 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, count = 0; j < 3; j++, count++)
                {
                    if (count != 2)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\n");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = ds.SaveToFileTextData(matrix);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}