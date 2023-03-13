// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Введите количство строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количство столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

Console.WriteLine($"Строкa с наименьшей суммой - {GetRowNumber(numbers)}");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int GetRowNumber(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}