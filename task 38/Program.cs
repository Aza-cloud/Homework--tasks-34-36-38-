// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
        Console.Write($"{res[i]} ");
    }
    return res;
}
double[] array = GetArray(10, -10, 10);
Console.WriteLine();

int index = 0;
double max_num = array[index];
while (index < array.Length)
{
    if (array[index] > max_num)
    {
        max_num = array[index];
    }
    else index = index + 1;
}
Console.WriteLine($"Максимальное число массива = {max_num}");

int index1 = 0;
double min_num = array[index1];
while (index1 < array.Length)
{
    if (array[index1] < min_num)
    {
        min_num = array[index1];
    }
    else index1 = index1 + 1;
}
Console.WriteLine($"Минимальное число массива = {min_num}");

double result = Math.Round(max_num - min_num, 5);
Console.WriteLine($"Разница между min и max = {result}");