// Задача 01. Напишите программу, которая на вход
// 1. принимает два числа 
// 2. проверяет, является ли первое число квадратом второго.
// 3. выводит результат
// Например:
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
Console.Clear();
Console.Write("Введите целое число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num2 / num1;
if(result == num1)
{
   Console.WriteLine("Является ли второе число квадратом первого?");
   Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Является ли второе число квадратом первого?");
    Console.WriteLine("Нет!"); 
}