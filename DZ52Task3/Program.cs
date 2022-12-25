// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();

int[,] myArray(int rows, int columns)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return arr;
}
int[,] array = myArray(4, 5);

void RowAvg(int[,] array)
{
    int cols = array.GetLength(0);
    int rows = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        float avg = 0;
        for (int x = 0; x < cols; x++)
        {
            avg += array[x, i];
        }
        avg = avg / cols;
        Console.Write(avg+" ");
    }
}
RowAvg(array);