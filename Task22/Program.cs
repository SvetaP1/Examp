// Напишите программу, которая на вход принимает число N
// и выдает таблицу квадратов чисел от 1 до N.
// пример: N= 5
// 1 1
// 2 4
// 3 9
// 4 16
// 5 25.

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    int num1 = 1;
    while (num1 < (num + 1))
    {
        Console.WriteLine($"{num1, 4} {num1 * num1, 4}");
        num1++;
    }
}
if (n > 0) SquareTable(n);
else Console.WriteLine("Число не является натуральным");