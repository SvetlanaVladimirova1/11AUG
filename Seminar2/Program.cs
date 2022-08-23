//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
//int num = new Random().Next(10,100);
//int num1 = num/10;
//int num2 = num%10;
//int max = num1;
//if (max<num2)
//{
//    max = num2
//}
//Console.WriteLine(num);
//Console.WriteLine(num1);
//Console.WriteLine(num2);

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//int num = new Random().Next(100,1000);
//int num1 = num/100;
//int num2 = num%10;
//Console.WriteLine(num);
//Console.Write(num1);
//Console.Write(num2);

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

//int num = new Random().Next(10,100);
//int num1 = new Random().Next(10,100);




//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да
//int num = new Random().Next(10,1000);
//Console.WriteLine(num);
//if(num%7 == 0 && num%23 == 0)
//{
//    Console.WriteLine("Число кратно");
//}
//else
//{
 //   Console.WriteLine("Число не кратно");
//}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int num = new Random().Next(100,1000);
int num1 = num/10;
int num2 = num1%10;
Console.WriteLine(num);
Console.Write(num2);
