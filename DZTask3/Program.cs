// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Произведением двух матриц будет матрица, элементы которой
// равны сумме попарных произведений элементов строки первой 
// матрицы на соответствующие элементы столбца второй матрицы: 
// Из этого следует что перемножить между собой можно матрицы,
// в которых количество столбцов первой равно количеству строк второй.

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
Console.Write("Введите число строк первой матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов первой матрицы (и строк второй): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов второй матрицы: ");
int p = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элементов матрицы (число должно быть >= 1): ");
int max = int.Parse(Console.ReadLine()!);

int[,] firstMatrix = new int[m, n];
NewArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
NewArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m, p];
MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Результирующая матрица (произведение 1-й и 2-й):");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}