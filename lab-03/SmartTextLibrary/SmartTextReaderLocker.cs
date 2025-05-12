using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartTextLibrary
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private readonly SmartTextReader _reader;
        private readonly Regex _denyPattern;

        public SmartTextReaderLocker(SmartTextReader reader, string pattern)
        {
            _reader = reader;
            _denyPattern = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public override char[][] ReadText(string filePath)
        {
            if (_denyPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadText(filePath);
        }
    }
}
