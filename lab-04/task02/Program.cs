
using AirportLibrary;



var runway1 = new Runway();
var runway2 = new Runway();

var aircraft1 = new Aircraft("AN-225");
var aircraft2 = new Aircraft("AN-124");
var aircraft3 = new Aircraft("Boeing 747");

var commandCentre = new CommandCentre(
    new[] { runway1, runway2 },
    new[] { aircraft1, aircraft2, aircraft3 });

Console.WriteLine("Сценарiй 1: Нормальна посадка двох лiтакiв");
aircraft1.Land();
aircraft2.Land();
Console.WriteLine();

Console.WriteLine("Сценарiй 2: Спроба посадки третього лiтака");
aircraft3.Land();
Console.WriteLine();

Console.WriteLine("Сценарiй 3: Злiт першого лiтака та посадка третього");
aircraft1.TakeOff();
aircraft3.Land();
Console.WriteLine();

Console.WriteLine("Сценарій 4: Злiт решти лiтакiв");
aircraft2.TakeOff();
aircraft3.TakeOff();
Console.WriteLine();

Console.WriteLine("Сценарiй 5: Повторна посадка всiх лiтакiв");
aircraft1.Land();
aircraft2.Land();
aircraft3.Land();
Console.WriteLine();



