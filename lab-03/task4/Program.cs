using System;
using SmartTextLibrary;

class Program
{
    static void Main()
    {
        string path = @"C:\University\course2\sem2\softwareDesign\lab-03\test.txt"; 

        SmartTextReader baseReader = new SmartTextReader();
        SmartTextChecker checker = new SmartTextChecker(baseReader);
        SmartTextReaderLocker locker = new SmartTextReaderLocker(checker, @"secret.*\.txt");

        Console.WriteLine("=== Читання дозволеного файлу ===");
        char[][] result = locker.ReadText(path);
        foreach (var line in result)
            Console.WriteLine(new string(line));

        Console.WriteLine("\n=== Спроба читання обмеженого файлу ===");
        locker.ReadText("secret-file.txt");
    }
}
