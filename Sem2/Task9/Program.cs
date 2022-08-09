// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
int a = number / 10;
int b = number % 10;
Console.WriteLine(number);
if (a > b) 
    Console.Write($"Наибольшая цифра: {a}");
else 
    Console.Write($"Наибольшая цифра: {b}");
