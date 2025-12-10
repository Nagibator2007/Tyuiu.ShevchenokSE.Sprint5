using Tyuiu.ShevchenokSE.Sprint5.Task7.V8.Lib;
namespace Tyuiu.ShevchenokSE.Sprint5.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutDataFileTask7V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);

        }
    }
}