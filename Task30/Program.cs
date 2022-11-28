// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// массив заполненный нулями:
// int[] arr = new int[8];
// int [] array1 = new int[8] {5,6,4,3,7,6,5,4};
// int [] array2 = {5,6,4,3,7,6,5,4};

int[] arr = new int[8];
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        // Console.WriteLine(array);
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
FillArray(arr);
PrintArray(arr);