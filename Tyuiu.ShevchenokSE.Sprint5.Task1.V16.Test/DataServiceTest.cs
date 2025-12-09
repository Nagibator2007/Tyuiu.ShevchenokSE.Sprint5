using Tyuiu.ShevchenokSE.Sprint5.Task1.V16.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\sergejbabidzonov\Desktop\source\repos\Tyuiu.ShevchenokSE.Sprint5\Tyuiu.ShevchenokSE.Sprint5.Task0.V15\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}