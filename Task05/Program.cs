﻿// Задача 05. Напишите программу, которая на вход 
// принимает одно число (N)
// на выходе показывает все целые числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//  2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = -num1;
while (count<=num1) 
{
    Console.Write($"{count}, "); 
    count ++ ;
}
