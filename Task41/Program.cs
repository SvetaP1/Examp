// Задача 41:
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


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
int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите число №{i + 1}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(arr);
int positiveNumbers = PositiveNumbers(arr);
Console.WriteLine($" -> {positiveNumbers}");