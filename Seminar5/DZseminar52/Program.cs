//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76




double[]array = new double[10];
int size = array.Length;

double max = array[0];
double min = array[0];


double raznost = 0;
for(int i=0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);

    if (array[i]>max)
    {
        max = array[i];

    }
    if (array[i]<min )
    {
    
         min = array[i];
    }
}
Console.WriteLine(String.Join(";", array));
Console.WriteLine("Макс. число = "+ max);
Console.WriteLine("Мин. число = "+ min);/raznost = max - min;
Console.WriteLine("Разность чисел = "+ raznost);




