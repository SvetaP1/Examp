// Задача 37.
// найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новом массиве. 
// [1 2 3 4 5 ] -> 5 8 3 
// [ 6 7 3 6] -> 36 21

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
int[] MultiplicationOfNumbersArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size +=1;
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
    newArray[i] = array[i] * array[array.Length - 1-i];
    }
    if (array.Length % 2 == 1) newArray[size -1 ] = array[size -1 ];
    return newArray;
}

int[] arr = CraeteArrayRndInt(7, 1, 10);
int[] newArr = MultiplicationOfNumbersArray(arr);
PrintArray(arr);
PrintArray(newArr);