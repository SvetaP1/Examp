//  Напишите программу, которая на вход принимает одно число (N),
//   а на выходе показывает все целые числа в промежутке от -N до N.
//  4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число:");
int nomber = Convert.ToInt32(Console.ReadLine());
int result = nomber * (-1);

while (result <= nomber)
{
    Console.Write(result);
    result = result + 1;
    Console.Write(",");
}
  
