// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

// Первый вариант
Console.Write("Введите число: ");
string str = Console.ReadLine().ToString();
if (str[0] == '-') // Проверка на ввод отрицательного числа
{
    if (str.Length <= 3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        Console.Write($"Третья цифра введенного числа: {str[3]}");
    }
}
else
{
    if (str.Length <= 2)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        Console.Write($"Третья цифра введенного числа: {str[2]}");
    }
}

//Второй вариант
/*Console.Write("Введите положительное число: ");
string str = Console.ReadLine().ToString();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}

if (str.Length > 2)
{
    Console.Write($"Третья цифра введенного числа: {array[2]}");
}
else
{
    Console.Write("Третьей цифры нет");
}*/

// Третий вариант
/*Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case < 0:
        Console.WriteLine("Вы ввели отрицательное число");
        break;
    case int i when i >= 0 && i < 100:
        Console.WriteLine("Третьей цифры нет");
        break;
    case int i when i >= 100 && i < 1000:
        Console.WriteLine($"Третья цифра введенного числа: {number % 10}");
        break;
    case int i when i >= 1000 && i < 10000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 10 % 10}");
        break;
    case int i when i >= 10000 && i < 100000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 100 % 10}");
        break;
    case int i when i >= 100000 && i < 1000000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 1000 % 10}");
        break;
    case int i when i >= 1000000 && i < 10000000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 10000 % 10}");
        break;
    case int i when i >= 10000000 && i < 100000000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 100000 % 10}");
        break;
    case int i when i >= 100000000 && i < 1000000000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 1000000 % 10}");
        break;
    case int i when i >= 1000000000:
        Console.WriteLine($"Третья цифра введенного числа: {number / 10000000 % 10}");
        break;
        
}*/