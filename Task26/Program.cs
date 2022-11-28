// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 456 ->3
// 78 ->2
// 89126 ->5

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int CountDigits(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num/10;
        count++;
    }
    return count == 0? 1: count; 
}
int countDigits = CountDigits(n);
Console.WriteLine($"Количество цифр в числе {n} - {countDigits}");