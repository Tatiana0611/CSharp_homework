// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"{number/100}{number%10}");

/*int number = new Random().Next(100, 1000);
Console.WriteLine($"Наше случайное число = {number}");
int numberA = number/100;
int numberC = number % 10;
Console.WriteLine(numberA*10 + numberC);*/

