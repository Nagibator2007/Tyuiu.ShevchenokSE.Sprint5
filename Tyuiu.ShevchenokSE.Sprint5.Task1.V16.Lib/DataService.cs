using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask1.txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y = Math.Sin(x) + (2.0 * x) / 3.0 - Math.Cos(x) * 4.0 * x;
                    y = Math.Round(y, 2);
                    string strY = y.ToString("F2", CultureInfo.InvariantCulture);
                    if (x != stopValue)
                    {
                        writer.WriteLine(strY);
                    }
                    else
                    {
                        writer.Write(strY);
                    }
                }
            }

            return path;
        }
    }
}
