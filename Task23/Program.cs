// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void СubeTable(int num)
{
    int num1 = 1;
    while (num1 < (num + 1))
    {
        Console.WriteLine($"{num1, 4} | {Math.Pow(num1, 3), 4}");
        num1++;
    }
}
if (n > 0) СubeTable(n);
else Console.WriteLine("Число не является натуральным");