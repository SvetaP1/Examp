// Задача 49:
// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

bool IsTriangle(int n1, int n2, int n3)
{
    return (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2);
    }
bool triangle = IsTriangle(a, b, c);
Console.WriteLine(triangle);