// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int row, int col, int min, int max) 
{
    
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
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
            Console.Write(j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i,j], 4}," : $"{matrix[i,j], 4} ");
        }
        Console.WriteLine("]");
    }
}

void MatrixSumIdx(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) // столбцы
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -9, 9);
PrintMatrix(array2D);
Console.WriteLine();
MatrixSumIdx(array2D);
PrintMatrix(array2D);