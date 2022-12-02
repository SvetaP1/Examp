// Задача 33.
// Задайте массив. Напишите программу,
//  которая определяет, присутствует ли данное число в массиве.

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
int[] arr = CraeteArrayRndInt(4, -10, 10);
PrintArray(arr);

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

bool Search(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
bool result = Search(arr, a);
Console.WriteLine(result ? "Да" : "Нет");