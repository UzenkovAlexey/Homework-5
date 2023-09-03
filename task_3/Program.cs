// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());
double[] ranArray = new double[array];

void FillArray(int array)
{
 Random ran = new Random();
  for (int i = 0; i < array; i++)
  {
   ranArray[i] = ran.NextDouble();
   Console.Write($"{ranArray[i]:F2} ");
  }

}

double DiffElements(double[] ranArray)
{
 double min = ranArray[0];
 double max = ranArray[0];
 int i = 1;
  while (i < ranArray.Length)
  {
   if (max < ranArray[i])
       max = ranArray[i];
   if (min > ranArray[i])
       min = ranArray[i];
       i = i + 1;
  }
  return max - min;
}

FillArray(array);
Console.WriteLine(" ");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DiffElements(ranArray):F2}");