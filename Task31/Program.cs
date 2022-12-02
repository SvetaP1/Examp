// задача 31.
// Задайте массив из 12 эл-тов
//  заполненный случайными числами из промежутка [-9,9].
// вывод массива.
// Найдите сумму отрицательных и положительных элементов массива. 

int[] CraeteArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CraeteArrayRndInt(12, -9, 9);
PrintArray(arr);

int GetSumPositiveElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int GetSumNegativeElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");