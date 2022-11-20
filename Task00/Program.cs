// Напишите программу,
// которая на вход принимает число
// выдаёт его квадрат (число умноженное на само себя).

// Например: 
// 4 -> 16 
// -3 -> 9
// -7 -> 49

Console.WriteLine("Ведите целое число:");
int nomber = Convert.ToInt32(Console.ReadLine());
// int nomber1 = int.Parse(Console.ReadLine()); - альтернативный способ перевести строку в число.
int square = nomber*nomber;
Console.WriteLine($"Квадрат числа {nomber} = {square}.");
