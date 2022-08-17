// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// Первый вариант
// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(1, 10);
//     Console.WriteLine(arr[i]);
// }

// Второй вариант

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

int[] n = new int[8];

Console.WriteLine("[" + string.Join(", ", FillArray(n)) + "]");
