// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = N;

if (N > 0)
{
    while (count >= -N)
        {
            Console.Write(count);
            Console.Write(" ");
            count--;
        }
}
    
if (N < 0)
{
    while (count <= -N)
        {
            Console.Write(count);
            Console.Write(" ");
            count++;
        }
}