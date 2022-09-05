﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{
    
    if (n < m)
    {
        return 0;
    }
    return n + Sum(m, n - 1);
}

if (n > m) Console.WriteLine(Sum(m, n));
else Console.WriteLine(Sum(n, m));