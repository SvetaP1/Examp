// задача 45. 
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.


int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i< array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
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

int[] arr = {5,4,6,7};
int[] newarr = CopyArray(arr);
PrintArray(newarr);