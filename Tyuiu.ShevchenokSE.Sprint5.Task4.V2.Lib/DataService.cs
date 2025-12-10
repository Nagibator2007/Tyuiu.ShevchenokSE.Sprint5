using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task4.V2.Lib
{
    public class DataService : ISprint5Task4V2
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double x = Double.Parse(strx, CultureInfo.InvariantCulture);
            double numerator = Math.Cos(x) + 3 * x;
            double denominator = 0.25 * x;
            double res = numerator / denominator + 4 - 2.1 * x;
            return Math.Round(res, 3);
        }
    }
}