using System.Collections.Generic;
using System.IO;

namespace Lab3
{
    public class ReadFile
    {
        private string Path;

        public ReadFile(string path)
        {
            Path = path;
        }

        public List<string> Read()
        {
            List<string> data = new List<string>();
            using (StreamReader sr = new StreamReader(Path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    data.Add(str);
                }
            }

            return data;
        }
    }
}