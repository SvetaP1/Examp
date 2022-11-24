// Напишите программу,
// которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

//  78 ->8
//  12 ->2
//  85 ->8

int nomber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {nomber}");

// int firstDigit = nomber / 10;
// int secondDigit = nomber % 10;

// if (firstDigit > secondDigit) Console.WriteLine ($"наибольшая цифра числа {firstDigit}");
// else Console.WriteLine($"наибольшая цифра числа {secondDigit}");
// Console.WriteLine($"наибольшая цифра числа {Math.Max(firstDigit, secondDigit)}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}

int maxDigit = MaxDigit(nomber);
Console.WriteLine($"наибольшая цифра числа {maxDigit}");

