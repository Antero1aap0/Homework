// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
int number = new Random().Next(10, 100000);
int result = number % 10;
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    result = number % 10;
    Console.WriteLine($"В числе {number} третьей цифрой является {result}");
}
else if (number < 100)
{
    Console.WriteLine($"В числе {number} -> третьей цифры нет");
}
