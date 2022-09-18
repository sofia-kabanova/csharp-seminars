// Задача 8: Напишите программу, которая
// на вход принимает число (N), 
//выходе показывает все чётные числа от 1 до N.
//
Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <=1) Console.Write("Диапазон для поиска четных чисел не задан");
else Console.WriteLine($"Вывожу четные числа в диапазоне от 1 до {num}:");
int count = 2;
while (count>=2 && count<=num) 
{
    if (count % 2 == 0)
    {
        
        Console.WriteLine($"{count}");
    }
    count ++ ;
}