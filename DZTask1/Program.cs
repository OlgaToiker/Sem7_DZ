// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки
// двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Задайте количество строк (m) двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов (n) двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение диапазона ячеек массива (от 1 до max): ");
int max = int.Parse(Console.ReadLine()!); 
Console.WriteLine($"Задан массив:");

int[,] matrix = new int[m, n];
ArrayMax(matrix);
PrintArray(matrix);

Console.WriteLine($"В итоге получается отсортированный массив: ");
SortArray(matrix);
PrintArray(matrix);

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if (matrix[i, m] < matrix[i, m + 1])
                {
                    int t = matrix[i, m + 1];
                    matrix[i, m + 1] = matrix[i, m];
                    matrix[i, m] = t;
                }
            }
        }
    }
}

void ArrayMax(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}