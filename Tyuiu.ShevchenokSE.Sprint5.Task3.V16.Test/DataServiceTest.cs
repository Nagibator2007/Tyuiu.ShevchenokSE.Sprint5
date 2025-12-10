using Tyuiu.ShevchenokSE.Sprint5.Task3.V16.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            double x = 3;
            double result = ds.Calculate(x);
            result = Math.Round(result, 3);
            double wait = 6.426;
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}