// Написать программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

// 456 ->46
// 782 ->72
// 918 ->98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// Console.WriteLine($"Первая цифра трехзначного числа -> {firstDigit}");
// Console.WriteLine($"Третья цифра трехзначного числа -> {thirdDigit}");

// int newResult = firstDigit*10 + thirdDigit;
// Console.WriteLine($"Новое число -> {newResult}");

int NewResult (int num)
{
int firstDigit = num / 100;
int thirdDigit = num % 10;
return firstDigit*10 + thirdDigit;
}
int newResult = NewResult (number);
Console.WriteLine($"Новое число -> {newResult}");