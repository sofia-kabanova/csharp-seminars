// Напишите программу, которая принимает 
// на вход трёхзначное число
// на выходе показывает последнюю цифру этого числа.
// Например:
// 456 -> 6 782 -> 2 918 -> 8
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<1000 && num>99)
{
    int last = num%10;
    Console.Write($"Последняя цифра вашего числа {num} - это цифра {last}");
}
else 
{
    Console.Write ("Ошибка, введите трехзначное число");
}
