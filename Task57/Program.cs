// Задача 57:
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию, сколько раз встречается элемент входных данных. 

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
int[] ReversMatrixToArray(int[,] matrix)
{
int[] array = new int[matrix.GetLength(0)*matrix.GetLength(1)];
int num = 0;
while (num < array.Length)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[num] = matrix[i,j];
            num ++;
        }
    }    
}
return array;
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
void PrintResult(int[] array)
{
int count = 1;
int num = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] == num) count++;
    else
    {
        Console.WriteLine($"{num} встречается {count} раз");
        num = array[i];
        count = 1;
    }
}
Console.WriteLine($"{num} встречается {count} раз");
}


int[,] array2D = CraeteMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] matrixToArray = ReversMatrixToArray(array2D);
PrintArray(matrixToArray);
Array.Sort(matrixToArray);
Console.WriteLine();
PrintArray(matrixToArray);
Console.WriteLine();
PrintResult(matrixToArray);
