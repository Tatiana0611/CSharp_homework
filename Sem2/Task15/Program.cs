// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели (число от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case int i when i >= 1 && i <= 5:
        Console.WriteLine("Это будний день!");
        break;
    case int i when i == 6 || i == 7:
        Console.WriteLine("Это выходной день!");
        break;
}
