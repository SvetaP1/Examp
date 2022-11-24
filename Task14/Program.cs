// Написать программу, которая на вход принимает число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int number1 = 6;
int number2 = 5;

bool MultiplicityTwoDigits (int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 ==0;
}

bool result = MultiplicityTwoDigits (a, number1, number2);
string resultStr = result? "Да" :"Нет";
Console.WriteLine($"{a} -> {resultStr}");

