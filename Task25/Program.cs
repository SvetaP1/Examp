// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

int DegreeOfNum(int num1, int num2)
{ 
   int result = num1;
   for (int i = 1; i < num2; i++)
   {
    result = result*num1;
   }
    return result;
}
if ( b > 0 )
{
    int res = DegreeOfNum(a,b);
    Console.WriteLine($"{a} в степени {b} -> {res}");
}
else
{
    Console.WriteLine($"Число B не является натуральным");
}

