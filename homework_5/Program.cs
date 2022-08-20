// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [10];
// int count = 0;
// int size = array.Length;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     if(array[i]%2 == 0) count++;
// }
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Количество четных чисел в массиве = {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int [10];
// int sum = 0;
// int size = array.Length;
// for (int i = 0; i < size; i++)
// {
//     array[i]= new Random().Next(100);
// }
// for (int i = 1; i < size; i+=2)
// {
//     sum += array[i];
// }
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"Сумма чисел нечетных позиций = {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[10];
for (int i = 0; i < array.Length; i++ )
  {
    array[i] = new Random().NextDouble() * 100;
  }
Console.WriteLine($"[{String.Join(",", array)}]");
double Max = array[0];
double Min = array[0];
for (int i = 1; i < array.Length; i++)
  {
    if (Max < array[i])
    {
      Max = array[i];
    }
    if (Min > array[i])
    {
      Min = array[i];
    }
  }
double result = Max - Min;
Console.WriteLine($"Максимальное число в массиве = {Max}");
Console.WriteLine($"Минимальное число в массиве = {Min}");
Console.WriteLine($"Разница между между максимальным и минимальным элементами = {Math.Round(result,2)}");
