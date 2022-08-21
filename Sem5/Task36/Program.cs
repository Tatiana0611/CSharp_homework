// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int Sum(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] arr = FillArray(6, -9, 9);
Console.WriteLine('[' + string.Join(',', arr) + ']');
Console.WriteLine($"Сумма элементов массива с нечетными индексами: {Sum(arr)}");