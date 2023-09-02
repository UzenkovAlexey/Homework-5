// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = FillArray(10, 99, 1000);
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

PrintArray(array);
int count = 0;

 for (int j = 0; j < array.Length; j++)
 if (array[j] % 2 == 0)
 count++;

Console.WriteLine($"Количетво чётныx чисел масива = {count}");

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int l = 0; l < numbers.Length; l++)
    {
        Console.Write(numbers[l] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


    
