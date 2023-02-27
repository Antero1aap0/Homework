// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] arr = new int[8];
RandomArray(arr);
PrintArray(arr);

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

void RandomArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
}