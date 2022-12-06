// Задача 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// первые два числа Фибоначчи: 0 и 1.
// если N =5 -> 0 1 1 2 3 
// если N =3 -> 0 1 1 
// если N =7 -> 0 1 1 2 3 5 8


int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

int[] result = Fibonacci(7);
PrintArray(result);