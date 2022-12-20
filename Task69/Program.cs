// Задача 69.
// Напишите программу, которая на вход принимает два числа А и В, 
// и возводит число А в степень В. 

Console.WriteLine("Введите натуральное число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В:");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation( int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * Exponentiation(num1, num2 - 1);
}

int result = Exponentiation( a, b );
Console.WriteLine(result);