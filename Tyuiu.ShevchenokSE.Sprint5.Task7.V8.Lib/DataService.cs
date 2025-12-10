using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShevchenokSE.Sprint5.Task7.V8.Lib
{
    public class DataService : ISprint5Task7V8
    {
        public string LoadDataAndSave(string path)
        {
            string PathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V8.txt");
            FileInfo fileinfo = new FileInfo(PathSaveFile);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(PathSaveFile);
            }
            string str = File.ReadAllText(path);
            string newstr = "";
            foreach (char s in str)
            {
                if ((s >= 1040 && s <= 1105) && (char.IsUpper(s)))
                {
                    newstr += char.ToLower(s);
                }
                else
                {
                    newstr += s;
                }
            }
            File.AppendAllText(PathSaveFile, newstr);
            return PathSaveFile;
        }
    }
}