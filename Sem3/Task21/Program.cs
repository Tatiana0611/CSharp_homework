// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве

//Первый вариант
// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine().ToString());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine().ToString());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine().ToString());
// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine().ToString());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine().ToString());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine().ToString());
// double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
// Console.WriteLine(Math.Round(result,2));

//Второй вариант

double lenght(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{
    double result = Math.Sqrt(Math.Pow((arg4-arg1), 2) + Math.Pow((arg5-arg2), 2) + Math.Pow((arg6-arg3), 2));
    return result;
}

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine().ToString());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine().ToString());
Console.Write("Введите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine().ToString());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine().ToString());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine().ToString());
Console.Write("Введите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine().ToString());

double result = lenght(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(result,2));