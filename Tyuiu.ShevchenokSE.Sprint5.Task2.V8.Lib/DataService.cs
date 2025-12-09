using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask0.txt";
            string str = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int count = 0, j = 0; j < matrix.GetLength(1); j++, count++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (count != 2)
                    {
                        str += matrix[i, j].ToString() + ";";
                    }
                    else
                    {
                        str += matrix[i, j].ToString() + ";";
                    }
                }
                File.WriteAllText(path, str);
            }
            return path;
        }
    }
}