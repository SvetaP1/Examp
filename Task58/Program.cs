// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] resultMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
   for (int i = 0; i < matrix1.GetLength(0); i++)
   {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int n = 0; n < matrix2.GetLength(0); n++)
        {
            resultMatrix[i,j] += matrix1[i,n]*matrix2[n,j];
        }
     } 
   } 
   return resultMatrix;
}

int[,] array2D = CreateMatrixRndInt(2, 2, 1, 9);
int[,] array2DX = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(array2DX);
Console.WriteLine();
if (array2D.GetLength(1) == array2DX.GetLength(0))
{
int[,] multiplicationMatrix = MultiplicationMatrix(array2D, array2DX);
PrintMatrix(multiplicationMatrix);
}
else    Console.WriteLine("Невозможно");