// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
string str = Console.ReadLine().ToString();
int A = Convert.ToInt32(str.ToString());
int result = 0;
int i = 0;
while (i <= str.Length-1)
{
    result += Convert.ToInt32(str[i].ToString());
    i++;
}
Console.WriteLine($"Сумма цифр во введенном числе: {result}");
