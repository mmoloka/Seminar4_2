﻿//Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i < number; i++)
{
    if (i % 2 == 0) Console.Write($"{i}, ");
}
