// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно 
// числу 1, то программа выводит остаток от деления.
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("Числа кратны");
}
else 
{
    if (a > b)
    {
        Console.WriteLine($"Остаток от деления {a} на {b} равен {a%b}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления {b} на {a} равен {b%a}");
    }
}