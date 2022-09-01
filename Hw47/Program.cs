// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

void CreateMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteMatrixArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
      Console.Write("[");
        for (int j = 0; j < n; j++)
        {
            double num = Math.Round(matrix[i, j], 1);
            Console.Write(num + "|");
        }
        Console.WriteLine("]");
    }
}

CreateMatrixDouble(matrix);
WriteMatrixArray(matrix);
