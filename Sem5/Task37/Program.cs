// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] F(int[] array)
{
    int[] newArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length-1-i];
    }
    
    if(array.Length % 2 > 0)
    {
        newArray[newArray.Length-1] = array[array.Length/2];
    }
    return newArray;
}

int[] arr = FillArray(5, 0, 9);
int[] newArr = F(arr);
Console.WriteLine('[' + string.Join(',', arr) + ']');
Console.WriteLine('[' + string.Join(',', newArr) + ']');