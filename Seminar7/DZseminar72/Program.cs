// SЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВведите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[m, n];
for(int i=0; i < m; i++)
{
    for(int j=0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);

        Console.Write(matrix[i, j] + "\t");
    }
Console.WriteLine();
}

Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВведите координату y");
int y = Convert.ToInt32(Console.ReadLine());


if(x>=3 || y>=4)
{
     Console.Write("Такого элемента нет");
 }
else
{
       Console.Write(matrix[x, y]);
 }





