using Tyuiu.ShevchenokSE.Sprint5.Task0.V15.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\sergejbabidzonov\Desktop\source\repos\Tyuiu.ShevchenokSE.Sprint5\Tyuiu.ShevchenokSE.Sprint5.Task0.V15\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}