using LoggerLibrary;
using System;

class Program
{
    static void Main(string[] args)
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Це iнформацiйне повiдомлення");
        consoleLogger.Warn("Це попередження");
        consoleLogger.Error("Це повiдомлення про помилку");

        FileWriter writer = new FileWriter("log.txt");
        ILogger fileLogger = new FileLoggerAdapter(writer);
        fileLogger.Log("Файловий лог: iнформацiя");
        fileLogger.Warn("Файловий лог: попередження");
        fileLogger.Error("Файловий лог: помилка");

        Console.WriteLine("Програма завершила роботу.");
    }
}
