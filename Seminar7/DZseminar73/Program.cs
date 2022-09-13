// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВведите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[m, n];

Console.WriteLine("Заданный массив:");
for(int i=0; i < m; i++)
{
    for(int j=0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);

        Console.Write(matrix[i, j] + "\t");
    }
Console.WriteLine();
}

for(int j=0; j<n; j++)
{
    double sum = 0;
    for(int i=0; i<m; i++)
    {
            sum = sum + matrix[i,j];
    }
    Console.Write($"{Math.Round(sum/m,2)}; "); 
}    
