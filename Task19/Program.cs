// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

bool Polydrome(int number)
{
    int digit1 = number / 10000;
    int digit2 = number % 10;
    if (digit1 == digit2)
    {
        digit1 = digit1 % 10000;
        digit2 = digit2 % 10;
        if (digit1 == digit2) return true;
        else return false;
    }
    else return false;
}

if (num < 100000 && num > 9999)
// {
// Console.WriteLine(Polydrome(num));
// }
{
    bool result = (Polydrome(num));
    string resultStr = result ? "Да" : "Нет";
    Console.WriteLine($"{num} -> {resultStr}");
}
else Console.WriteLine("Введенное число не соответствует диапазону");

