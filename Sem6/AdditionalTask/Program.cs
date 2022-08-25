// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// (использовать рекурсию)
// 4 -> 24
// 5 -> 120

int Factorial(int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{n}! = " + Factorial(n));