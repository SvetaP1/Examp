// Написать программу, которая на вход принимает 2 числа
// и выводит является ли первое кратным второму
// Если число 1 не кратно числу 2, то выводит остаток от деления.
// 34, 5 -> 4
// 16, 4 -> кратно.

// Console.WriteLine("Введите два числа");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a % b == 0) 
// {
//     Console.WriteLine($" Число {a} кратно числу {b}");
// }
// else 
// {
//     int result = a % b;
// Console.WriteLine($" остаток от деления {a} на {b} равен {result}");
// }

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int num1, int num2)
{return num1 % num2;}

int result = Multiplicity( a, b );
if (result == 0 ) Console.WriteLine($" Число {a} кратно числу {b}");
else Console.WriteLine($" остаток от деления {a} на {b} равен {result}");