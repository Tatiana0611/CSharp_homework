// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double DifferenceMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] arr = FillArray(6);
Console.WriteLine('[' + string.Join("; ", arr) + ']');
Console.WriteLine($"Разность максимального и минимального элементов: {DifferenceMaxMin(arr)}");