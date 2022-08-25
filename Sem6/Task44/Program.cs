// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[n];
fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < n; i++)
{
    fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
} 

Console.WriteLine(string.Join(' ', fibonacci));