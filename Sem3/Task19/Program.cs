// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом

// Первый вариант
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine().ToString();
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Это число является полиндромом");
}
else
{
    Console.WriteLine("Это число не является полиндромом");
}

//Второй вариант
// Console.Write("Введите пятизначное число: ");
// string str = Console.ReadLine().ToString();
// int[] arr = new int[str.Length];
// for (int i = 0; i < str.Length; i++)
// {
//     arr[i] = Convert.ToInt32(str[i].ToString());
// }
// if (arr[0] == arr[4] && arr[1] == arr[3])
// {
//     Console.WriteLine("Это число является полиндромом");
// }
// else
// {
//     Console.WriteLine("Это число не является полиндромом");
// }