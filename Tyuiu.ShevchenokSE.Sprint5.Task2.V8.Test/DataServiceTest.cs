using Tyuiu.ShevchenokSE.Sprint5.Task2.V8.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\sergejbabidzonov\Desktop\source\repos\Tyuiu.ShevchenokSE.Sprint5\Tyuiu.ShevchenokSE.Sprint5.Task0.V15\bin\Debug\net8.0\OutPutFileTask2.txt"; 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}