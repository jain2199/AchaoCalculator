using System.IO;

namespace AchaoCalculate
{
    class CreatFile
    {
        public  CreatFile(string st)
        {
            StreamWriter sw = new StreamWriter("D:/subject.txt", true);
            sw.WriteLine(st);
            sw.Close();
        }
    }
}
