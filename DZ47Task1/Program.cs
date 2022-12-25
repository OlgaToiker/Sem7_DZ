// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

Console.Write("Задайте количество строк (m) двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов (n) двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
double[,] Array = new double[m, n];
Random random = new Random();

void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            Console.Write($"{matr[i, j]} "); 
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            matr[i, j] = Math.Round(random.NextDouble() * 100, 2);
        }
    }
}
FillArray(Array);
Console.WriteLine();
PrintArray(Array);