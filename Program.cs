﻿/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/* 
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.Write($"Max = {num1}, Min = {num2}");
}
else
{
    if(num1 == num2)
    {
        Console.Write("Введенные числа равны");
    }
    else
    {
        Console.Write($"Max = {num2}, Min = {num1}");
    }
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}

if (max < num3)
{
    max = num3;
}
Console.Write($"Max = {max}");
*/

/*
Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без 
остатка).

4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 > 0)
{
    Console.WriteLine("Число " + num + " - нечетное");
}
else
{
    Console.WriteLine("Число " + num + " - четное");
}


/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/