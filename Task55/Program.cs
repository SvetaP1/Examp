// Задание 55:
// Задайте двумерный массив.
// Напишите программу, которая меняет строки на столюцы. 
// В случае, если это не возможно программа должна вывести сообщение для пользователя.

int[,] CraeteMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

int[,] TurnMatrix(int[,] matrix)
{
 int[,] matrixResult = new int[ matrix.GetLength(0), matrix.GetLength(1)];
 for (int i = 0; i <  matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrixResult[i, j] = matrix[j, i];
    }
 }
 return matrixResult;
}

int[,] array2D = CraeteMatrixRndInt(5, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
if ( array2D.GetLength(0) == array2D.GetLength(1))
{
PrintMatrix(TurnMatrix(array2D));
}
else Console.WriteLine("Невозможно");
