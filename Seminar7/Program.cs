// See https://aka.ms/new-console-template for more information


//int rows = int.Parse(ConsoleReedLine());
//int column = Convert.ToInt32(Console.ReadLine());

//int [,] matrix = new int[rows,column];

//for(int i=0,i< matrix.GetLength, i++)
//{
    //for(int j=0,j< matrix.GetLength, j++)

    //matrix[i,j = new Random().Next(3,5)]



//}









//int rows  = Convert.ToInt32(Console.ReadLine()); // int.Parse == Convert.ToInt32
//Console.WriteLine();

//int columns = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine();
//int [,] matrix = new int [rows,columns];

//for(int i =0; i<matrix.GetLength(0); i++)
//{
    //for(int j =0; j<matrix.GetLength(1); j++)
    //{   
        //matrix[i,j] = new Random().Next(0,11);
        //Console.Write(matrix[i,j]+ "\t"); // вместо пробела " " можно поставить "\t"
    //}
   // Console.WriteLine();
//}




//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5



//Console.WriteLine("Введите количество строк: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов: ");
//int columns = Convert.ToInt32(Console.ReadLine());

//int[,] array = new int[rows,columns];

//for(int i=0; i<rows; i++)
//{
	//for(int j=0; j<columns; j++)
	//{
		//array[i,j]=i+j;
		//Console.Write(array[i,j] + "\t");

	//}
	//Console.WriteLine();
//}




//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Console.WriteLine("Введите количество строк: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов: ");
//int columns = Convert.ToInt32(Console.ReadLine());

//double[,] array = new double[rows,columns];

//Console.WriteLine("Первоначальный массив:");
//for(int i=0; i<rows; i++)
//{
	//for(int j=0; j<columns; j++)
	//{
		//array[i, j] = new Random().Next(1, 100);
		//Console.Write(array[i,j] + "\t");
	//}
	//Console.WriteLine();
	
//}
//Console.WriteLine();

//Console.WriteLine("Измененный массив:");
//for(int i=0; i<rows; i++)
//{
	//for(int j=0; j<columns; j++)
	//{
		//if(i%2==0 && j%2==0)
		//{
			//array[i,j]=Math.Pow(array[i,j], 2);
		//}
		//Console.Write(array[i,j] + "\t");
	//}
	//Console.WriteLine();
//}


//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int[rows, columns];
int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        if (i == j)
        {
            sum +=matrix[i,j] ;
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма = {sum}");

