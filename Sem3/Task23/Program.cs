// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

// Первый вариант
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)} ");
// }

// Второй вариант
void cube(int arg)
{
    int i = 1;
    while (i <= arg)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
        i++;
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
cube(N);