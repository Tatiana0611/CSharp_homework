// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrix(int[,] matrix)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }    
}


void CheckMatrixIndex(int[,] matrix, int row, int column)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
                Console.WriteLine($"Элемент с индексами [{i}, {j}]: {matrix[i,j]}");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine("Такого элемента нет");
}

int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);

int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

CheckMatrixIndex(matrix, row, column);