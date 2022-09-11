// Задача 03 Вариант записи когда без скобокю
// Возможен когда условие для проверки одно.
// Напишите программу, которая будет 
// Запрашивать у пользователя номер дня недели.
// Выдавать название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница
Console.Clear();
Console.Write("Введите номер дня недели от 1 до 7: ");
string day = Console.ReadLine();
if (day == "1") Console.Write("Понедельник");
else if (day == "2") Console.Write("Вторник");
else if (day == "3") Console.Write("Среда");
else if (day == "4") Console.Write("Четверг");
else if (day == "5") Console.Write("Пятница");
else if (day == "6") Console.Write("Суббота");
else if (day == "7") Console.Write("Восресенье");
else Console.Write("Такого дня недели не существует");