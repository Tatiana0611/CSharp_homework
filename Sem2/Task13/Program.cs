// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет
Console.Write("Введите число: ");
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
    Console.Write("Неверное число");
}
