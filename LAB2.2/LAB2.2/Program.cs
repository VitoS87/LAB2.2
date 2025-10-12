Console.WriteLine("Введите первое число ");
long x = long.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
long y = long.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
long z = long.Parse(Console.ReadLine());
if (x > y && x < z) { Console.WriteLine("Среднее по значению " + x); }
if (x < y && x > z) { Console.WriteLine("Среднее по значению " + x); }
if (y > x && y < z) { Console.WriteLine("Среднее по значению " + y); }
if (y < x && y > z) { Console.WriteLine("Среднее по значению " + y); }
if (z > y && z < x) { Console.WriteLine("Среднее по значению " + z); }
if (z < y && z > x) { Console.WriteLine("Среднее по значению " + z); };