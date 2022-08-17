// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// Первый вариант
// int[] arr = new int[8];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(1, 100);
//     Console.WriteLine(arr[i]);
// }

// Второй вариант

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 100);
//     }
//     return arr;
// }

// int[] n = new int[8];

// Console.WriteLine("[" + string.Join(", ", FillArray(n)) + "]");


// Третий вариант

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] n = new int[8];

Console.WriteLine("[" + string.Join(", ", FillArray(n)) + "]");
