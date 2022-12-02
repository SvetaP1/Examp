// Задача №35
// Задайте массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]
// пример 
// [5, 18, 123,6,2 ] -> 1
// [1, 2, 3, 6, 2] -> 0

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

int CountTwoDigitNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count +=1;
        }
    }
    return count;
}

int[] arr = CraeteArrayRndInt(123, 0, 200);
PrintArray(arr);
int result = CountTwoDigitNumbers(arr);
Console.Write($"-> {result}");