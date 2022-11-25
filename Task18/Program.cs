// Напишите программу, которая по заданному номеру четверти 
// показывает диапазон возможных координат точек в этой четверти (х и у).

Console.WriteLine("Введите номер четверти (число от 1 до 4)");
int x = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc)
{
    if (xc == 1) return "x > 0, y > 0";
    if (xc == 2) return "x < 0, y > 0";
    if (xc == 3) return "x < 0, y < 0";
    if (xc == 4) return "x > 0, y < 0";
    return "Введено неверное число";
}
string result = Quarter(x);
Console.WriteLine(result);