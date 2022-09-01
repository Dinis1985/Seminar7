// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
CreateMatrixRndInt(numbers);
Console.Write("Cреднее арифметическое каждого столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double arithmeticMean = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arithmeticMean = (arithmeticMean + numbers[i, j]);
    }
    arithmeticMean = arithmeticMean / n;
    Console.Write(arithmeticMean + "; ");
}

void CreateMatrixRndInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine();
PrintMatrix(numbers);


