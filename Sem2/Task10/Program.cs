// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number! / 10 % 10;
Console.WriteLine($"Вторая цифра введенного числа: {a}");

//Второй вариант
/*Console.Write("Введите число: ");
string str = Console.ReadLine().ToString();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}
Console.WriteLine($"Вторая цифра введенного числа: {array[1]}");*/