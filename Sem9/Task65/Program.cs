// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    PrintNumbers(m, n - 1);
    Console.Write(n + " ");
}

if (m < n) PrintNumbers(m, n);
else PrintNumbers(n, m);