﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
switch (quarter)
{
    case 1:
        Console.WriteLine("I четверть: x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("II четверть: x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("III четверть: x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("IV четверть: x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Такой четверти нет");
        break;
}
