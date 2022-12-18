// Задание 59:
// Задайте двумерный массив из целых чисел.
// Напишите программу,которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. 

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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
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
int[] FoundMinIndex(int[,] matrix)
{
    int[] index = new int[2];
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}
int[,] DeliteMinIndex(int[,] matrix, int[] array)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int column = 0;
        if (i != array[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != array[1])
                {
                    result[row, column] = matrix[i, j];
                    column++;
                }
            }
            row++;
        }
    }

    return result;
}

int[,] array2D = CraeteMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] num = FoundMinIndex(array2D);
PrintArray(num);
Console.WriteLine();
int[,] newArray = DeliteMinIndex(array2D, num);
PrintMatrix(newArray);