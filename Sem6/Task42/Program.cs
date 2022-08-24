// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Первый вариант
// string Fill(int number)
// {
//     string s = String.Empty;
//     while (number > 0)
//     {
//         s = s + number % 2;
//         number = number / 2;  
//     }
//     return s;
// }

// string Reverse(string s)
// {
//     char[] arr = s.ToCharArray();
//     Array.Reverse(arr);
//     return new string(arr);
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string result = Fill(number);
// string reverseResult = Reverse(result);
// Console.Write(reverseResult);

// Второй вариант
void Binary(int number)
{
    if (number <= 0) return;
    Binary(number / 2);
    Console.Write(number % 2);
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Binary(number);