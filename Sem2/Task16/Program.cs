﻿// Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA*numberA == numberB || numberB * numberB == numberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}