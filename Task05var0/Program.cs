﻿/// Задача 05. Напишите программу, которая на вход 
// принимает одно число (N)
// на выходе показывает все целые числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//  2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num; 
while (count<=num) 
{
   Console.Write($"{count}, ");
   count ++ ;
}
