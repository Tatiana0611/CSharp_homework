// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N
Console.Write("Введите число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = 1;
int i = 1;
while (i <= n)
{
    result *= i;
    i++;
}
Console.WriteLine(result);