// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

Console.Write("Задайте количество строк (m) двумерного массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте количество столбцов (n) двумерного массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное числовое значение ячеек массива (max): ");
int max = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Задан массив:");

int[,] array = new int[m, n];
NewArray(array);
PrintArray(array);

int minSum = 0;
int sumRow = SumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumRows(array, i);
    if (sumRow > temp)
    {
        sumRow = temp;
        minSum = i;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum + 1}.");


int SumRows(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
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