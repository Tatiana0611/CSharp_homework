﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m > 0) && (n == 0)) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

if (m < 0 || n < 0) Console.WriteLine("Введите положительные значения m и n");
else Console.WriteLine(AckermannFunction(m, n));