// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

// Первый вариант
// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine().ToString()));
// string str = Convert.ToString(number);
// Console.WriteLine(str.Length);

// Второй вариант
Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine().ToString()));
int count = 0;
while (number > 0)
{
    count++;
    number /= 10;
}
Console.WriteLine(count);