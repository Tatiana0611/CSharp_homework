Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корень этого числа: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("Вы правы!");
}
else
{
    Console.WriteLine("Вы не правы!");
}
bool result = (numberA == numberB*numberB);
Console.WriteLine(result);