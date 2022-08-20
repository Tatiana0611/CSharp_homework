// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange+1);
    }
    return array;
}

int[] arr = FillArray(6, -9, 10);
Console.WriteLine(string.Join(',', arr));

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == number)
    {
        count++;
    }
}

if (count > 0) Console.WriteLine("да");
else Console.WriteLine("нет");