// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int segmentElements(int[] array, int leftPoint, int rightPoint)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= rightPoint && array[i] >= leftPoint) count++;
    }
    return count;
}

int[] arr = FillArray(123, 0, 300);

int leftP = 10; 
int rightP = 99;
int segmElements = segmentElements(arr, leftP, rightP);

Console.WriteLine("Массив: [" + string.Join(',',arr) + ']');
Console.WriteLine();
Console.WriteLine($"Всего элементов в массиве: {arr.Length}");
Console.WriteLine($"Отрезок: [{leftP}, {rightP}]");
Console.WriteLine($"Количество элементов массива, лежащих в отрезке: {segmElements}");