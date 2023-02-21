// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int remineder = 0;
int sum = 0;
int temp = number;
while (number > 0)
{
    remineder = number % 10;
    sum = (sum * 10) + remineder;
    number = number / 10;
}
if (temp == sum)
{
    Console.WriteLine($"Число {temp} является палиндромом");
}
else
{
    Console.WriteLine($"Число {temp} не является палиндромом");
}