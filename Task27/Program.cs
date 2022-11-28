// Задача 27:
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;

   while (num >= 1)
    {
        int num1 = num % 10;
        num = num / 10;
        sum = sum + num1;
    }
    return sum;
}
int sumdigit = SumDigit(a);
Console.WriteLine(sumdigit);