Console.WriteLine("Введите два числа");
int nomber1 = Convert.ToInt32(Console.ReadLine());
int nomber2 = Convert.ToInt32(Console.ReadLine());

if (nomber1/nomber2 == nomber2)
{
    Console.WriteLine($"число {nomber1} является квадратом числа {nomber2}");
}
else
{
    Console.WriteLine($"число {nomber1} не является квадратом числа {nomber2}");
}