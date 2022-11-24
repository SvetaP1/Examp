// Задача 15:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, обозначающее номер дня недели (в диапазоне от 1 до 7)");
int a = Convert.ToInt32(Console.ReadLine());

bool Weekend(int num)
   {return num == 6 || num == 7;}

if (a < 1 || a > 7) Console.WriteLine("введите число от 1 до 7");

else
{
    bool result = Weekend(a);
    string resultStr = result ? "Выходной" : "Не выходной";
    Console.WriteLine($"{a} -> {resultStr}");
}