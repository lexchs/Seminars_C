﻿// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

for(int i = -num; i <= num; i += 1)
    Console.Write($"{i} ");
