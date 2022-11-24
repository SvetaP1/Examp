// напишите программу, которая принимает на вход 2 числа
// и проверяет, является ли одно квадратом другого
// 5, 25 -> да 
// -4, 16 -> да 
// 8,9 -> нет

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}
bool result = IsSquare(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");