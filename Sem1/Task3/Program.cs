//  Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.Write("Введите номер дня недели (число от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        Console.WriteLine("Первый день недели - понедельник");
        break;
    case 2:
        Console.WriteLine("Второй день недели - вторник");
        break;
    case 3:
        Console.WriteLine("Третий день недели - среда");
        break;
    case 4:
        Console.WriteLine("Четвертый день недели - четверг");
        break;
    case 5:
        Console.WriteLine("Пятый день недели - пятница. УРА!!!");
        break;
    case 6:
        Console.WriteLine("Шестой день недели - суббота");
        break;
    case 7:
        Console.WriteLine("Седьмой день недели - воскресенье");
        break;
}
