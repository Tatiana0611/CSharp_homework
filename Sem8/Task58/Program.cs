// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum; 
        }
    }
    return matrixC;
}

int[,] matrixA = new int[2, 4];
int[,] matrixB = new int[4, 2];
FillMatrix(matrixA);
FillMatrix(matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();

if (matrixA.GetLength(0) != matrixB.GetLength(1))
{
    Console.WriteLine("Невозможно выполнить умножение матриц.");
}
else
{
    int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
    PrintMatrix(matrixC);
}