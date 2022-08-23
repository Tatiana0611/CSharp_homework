// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int NumberOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
FillArray(array);

// Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество положительных чисел: {NumberOfPositiveNumbers(array)}");