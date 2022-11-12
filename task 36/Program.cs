// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(10, -10, 10);
Console.WriteLine();

int SumNegativePosition = 0;
int index = 0;
int num = array[index];
while (index < array.Length)
{
    if (index % 2 != 0)
    {
       SumNegativePosition = SumNegativePosition + array[index];
    }
    index++;
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumNegativePosition}");
