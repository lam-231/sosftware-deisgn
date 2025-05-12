using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartTextLibrary
{
    public class SmartTextReader
    {
        public virtual char[][] ReadText(string filePath)
        {
            List<char[]> lines = new List<char[]>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line.ToCharArray());
                }
            }
            return lines.ToArray();
        }
    }
}
