﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2) 
{
    Console.WriteLine("Введите пожалуста число больше 1");    
}
else {
    int cur = 2;
    while (cur <= n) 
    {
        Console.Write($"{cur} ");
        cur += 2;
    }
}

