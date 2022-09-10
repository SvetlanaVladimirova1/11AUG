// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3




double[] array = new double[10];

int size = array.Length;
int count = 0;
int i = 0;
for(i = 0; i < size; i++)
{

    array[i] = new Random().Next(-10, 10);

    if(array[i]>0)
    {
        count++;
    }
}



Console.WriteLine(String.Join(";", array));

Console.WriteLine("Чисел больше 0 = " + count);
