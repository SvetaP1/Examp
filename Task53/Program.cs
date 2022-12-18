// Задача 53:
// Задайте двумерный массив. 
// Напишите программу, которая меняет местами первую и последнюю строку массива. 

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

int[,] ChangeMatrix(int[,] matrix)
{
int num = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    num = matrix[0,j];
    matrix[0,j] = matrix[matrix.GetLength(0) -1,j];
    matrix[matrix.GetLength(0) - 1,j] = num;
}
return matrix;
}

int[,] array2D = CraeteMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
ChangeMatrix(array2D);
Console.WriteLine();
PrintMatrix(array2D);