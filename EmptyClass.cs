using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace francyzskayaPracticheskaya
{
    public static class GetFiles
    {
        public static List<Failik> Get(string path)
        {
            List<Failik> failikList = new List<Failik>();
            foreach (string file in Directory.GetDirectories(path))
                failikList.Add(new Failik(file.Split("\\")[^1] + "\\", file));
            foreach (string file in Directory.GetFiles(path))
                failikList.Add(new Failik(file.Split("\\")[^1], file));
            return failikList;
        }
    }
    public class Kursor
    {
        public Kursor(int max = 1, int min = 1, int pos = 1)
        {
            this.max = max;
            this.min = min;
            this.pos = pos;
        }
        public int max, min, pos;
    }
    public static class ShowInformation
    {
        public static void ShowDirs(List<Failik> papkaList)
        {
            foreach (Failik elem in papkaList)
                Console.WriteLine("   " + elem.name);
        }
    }
    public class Failik
    {
        public Failik(string name, string path)
        {

            this.path = path;
            this.name = name;
        }
        public string name;
        public string path;
    }
}