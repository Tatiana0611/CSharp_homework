// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B

// Первый вариант
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// int i = 1;
// while (i <= B)
// {
//     result *= A;
//     i++;
// }
// Console.WriteLine($"{A} в степени {B} равно {result}");

// Второй вариант
int Pow(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int pow = Pow(power: B, number: A);
Console.WriteLine($"{A} в степени {B} равно {pow}");
