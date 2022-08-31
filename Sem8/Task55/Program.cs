// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReplaceRowsWithColumns(int[,] matrix)
{
    int[,] replaceMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < replaceMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < replaceMatrix.GetLength(1); j++)
        {
            replaceMatrix[i, j] = matrix[j, i];
        }
    }
    return replaceMatrix;
}
    


int[,] matr = new int[4, 5];
FillMatrix(matr);
PrintMatrix(matr);
Console.WriteLine();

if (matr.GetLength(0) != matr.GetLength(1)) 
{
    Console.WriteLine("Невозможно заменить строки на столбцы");
}
else
{
    int[,] repMatr = ReplaceRowsWithColumns(matr);
    PrintMatrix(repMatr);
}