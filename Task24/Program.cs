// Напишите программу, которая на вход принимает число (А)
// и выводит сумму чисел от 1 до А
// 7-> 28
// 4->10
// 8->36

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
        // sum +=i;
    }
    return sum;
}

if (number > 0)
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумму чисел от 1 до А = {sumNumbers}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число");
}