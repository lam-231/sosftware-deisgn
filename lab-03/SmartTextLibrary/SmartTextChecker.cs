using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SmartTextLibrary
{
    public class SmartTextChecker : SmartTextReader 
    {
        private readonly SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public override char[][] ReadText(string filePath)
        {
            Console.WriteLine($"[INFO] Opening file: {filePath}");

            char[][] result;
            try
            {
                result = _reader.ReadText(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"[ERROR] Failed to read file: {e.Message}");
                throw;
            }

            Console.WriteLine($"[INFO] Successfully read file.");
            Console.WriteLine($"[INFO] Total lines: {result.Length}");
            int totalChars = 0;
            foreach (var line in result)
                totalChars += line.Length;

            Console.WriteLine($"[INFO] Total characters: {totalChars}");
            Console.WriteLine($"[INFO] Closing file.");

            return result;
        }
    }
}
