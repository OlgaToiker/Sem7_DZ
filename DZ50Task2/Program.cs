// Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого
// элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

Console.Write("Введите позицию строки искомого элемента: ");
int row = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите позицию столбца искомого элемента: ");
int column = int.Parse(Console.ReadLine()!) - 1;
Random random = new Random();

int[,] myArray(int rows, int columns) 
{ 
    int[,] arr = new int[rows, columns]; 
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
        for (int j = 0; j < arr.GetLength(1); j++) 
        { 
            arr[i, j] = new Random().Next(1,100); 
            System.Console.Write(arr[i, j] + " "); 
        } 
        System.Console.WriteLine(); 
    } 
    return arr; 
}

int[,] array = myArray(4, 4);


if (row < 0 | row > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
    Console.Write("Элемент не существует  ");
else
    Console.WriteLine("Значение элемента массива = {0}", array[row, column]);