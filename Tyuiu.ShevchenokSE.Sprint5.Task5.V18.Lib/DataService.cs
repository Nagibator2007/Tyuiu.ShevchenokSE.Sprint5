using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double product = 1;
            bool foundTwoDigitNumber = false;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line.Trim(), out double number))
                    {
                        if ((number >= 10 && number <= 99) || (number <= -10 && number >= -99))
                        {
                            number = Math.Round(number, 3);
                            product *= number;
                            foundTwoDigitNumber = true;
                        }
                    }
                }
            }
            if (!foundTwoDigitNumber)
            {
                return 0;
            }
            return Math.Round(product, 3);
        }
    }
}