using Tyuiu.ShevchenokSE.Sprint5.Task4.V2.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V2.txt";
            DataService ds = new DataService();
            double res = ds.LoadFromDataFile(path);
            Assert.IsTrue(!double.IsNaN(res) && !double.IsInfinity(res));
        }
    }
}