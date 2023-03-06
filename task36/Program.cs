// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
int sum = 0;
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 1)
        sum += numbers[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}