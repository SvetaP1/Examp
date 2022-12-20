// Задача 65:
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите два числа:");
Console.WriteLine("M =");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N =");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbersMinToMax(m,n);

void NaturalNumbersMinToMax(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersMinToMax(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
         Console.Write($"{num1} ");
        NaturalNumbersMinToMax(num1 + 1, num2);
    }
    else Console.Write($"{num1} ");
}