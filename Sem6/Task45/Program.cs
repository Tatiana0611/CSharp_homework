// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] FillArray(int value)
{
    int[] array = new int[value];
    for (int i = 0; i < value; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

Console.Write("Количество элементов в заданном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(n);
int[] copyArr = CopyArray(arr);
Console.WriteLine("Заданный массив [" + string.Join(", ", arr) + ']');
Console.WriteLine("Копия заданного массива [" + string.Join(", ", copyArr) + ']');