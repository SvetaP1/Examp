// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве. 
// А (3, 6); В (2, 1) -> 5,09
// А (7, -5); В 1, -1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int xc2, int yc1, int yc2)
{
    return Math.Sqrt((xc2-xc1)*(xc2-xc1) + (yc2-yc1)*(yc2-yc1));
}
double result = Math.Round(Distance(x1, x2, y1, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между заданными точками = {result}");
