// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = FillArray(5, 1, 20);
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++) 
    {
        array[i] = random.Next(minValue, maxValue+1);
    }  
    return array; 
}
Console.WriteLine(string.Join(" ", array));

int SumNumbers(int[] array)
{
int sum = 0;
int i = 0;
while (i < array.Length)
{
sum = sum + array[i];
i = i + 2;
}
return sum;
}

Console.Write($"Cумма элементов, стоящих на нечётных позициях:{SumNumbers(array)}");