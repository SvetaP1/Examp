// Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int MultiplicationNumbers(int num)
{
    int mult = 1;
    for (int i = 1; i < num + 1; i++)
    {
        mult = mult * i;
    }
    return mult;
}

if (n > 0)
{
    int result = MultiplicationNumbers(n);
    Console.WriteLine($"{n} -> {result}");
}
else
{
    Console.WriteLine("Требуется ввести натуральное число");
}
