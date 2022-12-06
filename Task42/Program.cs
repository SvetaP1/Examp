// Задача 42.
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

string ConvertToBin(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;
}
Console.WriteLine(ConvertToBin(num));