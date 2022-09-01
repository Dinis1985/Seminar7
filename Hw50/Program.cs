// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[3, 4];

CreateMatrixRndInt(numbers);

void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "|");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

PrintMatrix(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    Console.WriteLine($"/{n},{m}/ -> такого элемента в массиве нет");
else Console.WriteLine($"Значение элемента на позиции /{n},{m}/-> {numbers[n - 1, m - 1]}");
