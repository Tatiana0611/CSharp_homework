// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N

// Первый вариант
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i = 1;
while (i <= n)
{
    result *= i;
    i++;
}
Console.WriteLine(result);

// Второй вариант

// int f(int arg)
// {
//     int result = 1;
//     for (int i = 1; i <= arg; i++)
//     {
//         result *= i;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(f(n));