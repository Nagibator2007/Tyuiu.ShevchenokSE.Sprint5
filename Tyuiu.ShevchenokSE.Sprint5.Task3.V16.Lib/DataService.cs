using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public double Calculate(double x)
        {
            double numerator = 2 * Math.Pow(x, 2) - 1;
            double denominator = Math.Sqrt(Math.Pow(x, 2) - 2);
            return numerator / denominator;
        }

        public string SaveToFileTextData(int x)
        {
            throw new NotImplementedException();
        }
    }
}