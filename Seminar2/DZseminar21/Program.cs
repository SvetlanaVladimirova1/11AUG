// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число от 0 до 100000");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
if (num<99)
{
Console.WriteLine("третьей цифры нет"); 
}
else {
if (num > 99 && num < 1000) num1 = num / 1;
if (num > 999 && num < 10000) num1 = num / 10;
if (num > 9999 && num < 100000) num1 = num / 100;
num1 = num1 % 10;  

    Console.WriteLine(num1);
     }
