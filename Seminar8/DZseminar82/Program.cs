// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Первоначальный массив:");
int[,] array = new int[new Random().Next(1,10), new Random().Next(1, 10)];
int min = int.MaxValue;
int k = 0;
int sum = 0;
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
        
    }
    Console.WriteLine();
}
Console.WriteLine("  ");
for(int i=0; i<array.GetLength(0); i++)
{   
    sum = 0;
    for(int j=0; j<array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
    }      
    Console.WriteLine("Сумма = " + sum); 
   
    if (min > sum)
    {
        min = sum;
        k = i;
    }
   
}   
    Console.WriteLine($"строка с мин.суммой = {k+1}"); 
      