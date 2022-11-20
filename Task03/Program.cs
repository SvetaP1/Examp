// Напишите программу, 
// которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7");
int nomber = Convert.ToInt32(Console.ReadLine());

if (nomber ==1 ) Console.WriteLine("понедельник");
else if (nomber == 2) Console.WriteLine("вторник");
else if (nomber == 3) Console.WriteLine("среда");
else if (nomber == 4) Console.WriteLine("четверг");
else if (nomber == 5) Console.WriteLine("пятница");
else if (nomber == 6) Console.WriteLine("суббота");
else if (nomber == 7) Console.WriteLine("воскресенье");
else Console.WriteLine("неверное число");
