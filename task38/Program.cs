//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] startArray = GetArray(6);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifferance(startArray)}");

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 10;
    }
    return res;
}
double GetDifferance(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}