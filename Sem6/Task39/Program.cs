﻿// Задача 39: Напишите программу, которая перевернет одномернай массив
// (поcледний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

const int ARRAY_SIZE = 5;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 19;

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

void ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
 int[] array = FillArray(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
 Console.WriteLine('[' + string.Join("; ", array) + ']');
 ReverseArray(array);
 Console.WriteLine('[' + string.Join("; ", array) + ']');