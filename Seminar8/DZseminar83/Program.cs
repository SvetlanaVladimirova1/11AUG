// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("Введите количество строк m1");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВведите количество столбцов n1 = m1");
int n1 = Convert.ToInt32(Console.ReadLine());
int m2 = n1;
int n2 = m1;
int [,] matrix1 = new int[m1, n1];


Console.WriteLine("Первый массив:");
for(int i=0; i < m1; i++)
{
    for(int j=0; j < n1; j++)
    {
        matrix1[i,j] = new Random().Next(1,10);

        Console.Write(matrix1[i, j] + "\t");
    }
Console.WriteLine();
}
Console.WriteLine("Второй массив:");
int [,] matrix2 = new int[m2, n2];
for(int i=0; i < m2; i++)
{
    for(int j=0; j < n2; j++)
    {
        matrix2[i,j] = new Random().Next(1,10);

        Console.Write(matrix2[i, j] + "\t");
    }
Console.WriteLine();
}
Console.WriteLine("Произведение массивов:");
int [,] matrix3 = new int[m2, n2];
for(int i=0; i < m2; i++)
{
    for(int j=0; j < n2; j++)
    {
        for(int k=0; k < n2;k++)
        {
            matrix3[i,j] +=  matrix1[i,k]* matrix2[k,j];
        }
        Console.Write(matrix3[i, j] + "\t");
    }
    Console.WriteLine();
    
}    

