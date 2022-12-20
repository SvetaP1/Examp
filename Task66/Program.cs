// Задача 66:
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите два числа:");
Console.WriteLine("M =");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("N =");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumbersSum(int num1, int num2)
{
   int sum = 0;
    if (num1 > num2)
    {
        sum = num1 + NaturalNumbersSum(num1 - 1, num2);
    }
    else if (num1 < num2)
    {
        sum = num1 + NaturalNumbersSum(num1 + 1, num2);
    }
    else sum = num1;
    return sum;
}

int result = NaturalNumbersSum(m,n);
Console.WriteLine(result);