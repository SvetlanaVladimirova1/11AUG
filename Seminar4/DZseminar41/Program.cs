// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число степени a");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Math.Pow(n,a));
