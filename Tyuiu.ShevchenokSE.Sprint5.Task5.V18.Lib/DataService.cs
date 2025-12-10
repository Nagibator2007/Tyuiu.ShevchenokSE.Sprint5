using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double product = 1.0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number))
                    {
                        int integerValueForCheck = (int)Math.Round(number);
                        if ((integerValueForCheck >= 10 && integerValueForCheck <= 99) ||
                            (integerValueForCheck >= -99 && integerValueForCheck <= -10))
                        {
                            product *= number;
                        }
                    }
                }
            }
            return Math.Round(product, 3);
        }
    }
}