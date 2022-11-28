// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33
// -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = new int[8];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }

    Console.Write("]");
}

FillArray(arr);
PrintArray(arr);
