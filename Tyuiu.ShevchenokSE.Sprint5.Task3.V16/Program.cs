using Tyuiu.ShevchenokSE.Sprint5.Task3.V16.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Шевченок С.Е   | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Шевченок Сергей Евгеньевич |  СМАРТб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: g(x) = (2*x^2 - 1)/√(x^2 - 2)                           *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат сохранить в бинарный        *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль.                          *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x = 3;
            Console.WriteLine($"x = {x}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.Calculate(x);
            double roundedResult = Math.Round(result, 3);
            Console.WriteLine($"Результат вычисления: {result}");
            Console.WriteLine($"Округлённый результат (3 знака): {roundedResult}");
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Append)))
            {
                writer.Write(roundedResult);
            }

            Console.WriteLine($"Результат сохранён в файл: {outputFile}");
            Console.ReadKey();
        }
    }
}