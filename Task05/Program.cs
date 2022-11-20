Console.WriteLine("Введите целое число:");
int nomber = Convert.ToInt32(Console.ReadLine());
int result = nomber * (-1);

while (result <= nomber)
{
    Console.Write(result);
    result = result + 1;
    Console.Write(",");
}
  
