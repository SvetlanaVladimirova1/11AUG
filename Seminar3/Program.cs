// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координату x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x3");
int x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y3");
int y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z3");
int z3 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));

Console.WriteLine(d);


