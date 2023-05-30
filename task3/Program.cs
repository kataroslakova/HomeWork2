System.Console.WriteLine("Введите номер дня недели");
int x = int.Parse(Console.ReadLine()!);
if (x == 1 || x == 2 || x == 3 || x == 4 || x == 5)
System.Console.WriteLine("День под эти номером не выходной");
else if (x > 7)
System.Console.WriteLine("Такого дня недели нет");
else
System.Console.WriteLine("День под этим номером выходной");
