// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введите сторону a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b+c && b < a+c && c < a+b) Console.WriteLine("Такой треугольник может существовать");
else Console.WriteLine("Такой треугольник не может существовать");