// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];
int n = 1;
int l = matrix.GetLength(0);

for (int i = 0; i < l / 2; i++)
{
    for (int j = i; j < l - i; j++) matrix[i, j] = n++;
    for (int j = i + 1; j < l - i; j++) matrix[j, l - 1 - i] = n++;
    for (int j = l - i - 2; j >= i; j--) matrix[l - 1 - i, j] = n++;
    for (int j = l - 2 - i; j > i; j--) matrix[j, i] = n++;
}

// Печать массива
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + " ");
        else Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}