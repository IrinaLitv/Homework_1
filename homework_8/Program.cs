// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:                   В итоге получается вот такой массив:
// 1 4 7 2                                  7 4 2 1
// 5 9 2 3                                  9 5 3 2
// 8 4 2 4                                  8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int [rows,columns];
// FillArray(numbers);
// PrintArray(numbers);
// Console.WriteLine("Новый массив: ");

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int k = 0; k < numbers.GetLength(1) - 1; k++)
//         {
//             if (numbers[i, k] < numbers[i, k + 1])
//             {
//                 int temp = 0;
//                 temp = numbers[i, k];
//                 numbers[i, k] = numbers[i, k + 1];
//                 numbers[i, k + 1] = temp;
//             }
//         }
//     }
//}
//PrintArray(numbers);

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
// }
// void PrintArray (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1)-1; j++)
//     {
//         for (int k = 0; k < numbers.GetLength(1)-1; k++)
//         {
//             if (numbers[i,k] < numbers[i,k+1])
//             {
//                 int temp = numbers[i,k];
//                 numbers[i,k] = numbers[i,k+1];
//                 numbers[i,k+1] = temp;
//             }
//         }
//         Console.Write(numbers[i,j] + "\t");
//     }
// }
// Console.WriteLine();




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:  1 4 7 2
//                          5 9 2 3
//                          8 4 2 4
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int rows = number;
// int columns = number;
// int[,] array = new int[rows, columns];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
// }
// void PrintArray (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int minSum = int. MaxValue;
// int rowIndex = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];        
//     }
//     if (sum < minSum)
//     {
//         minSum = sum;
//         rowIndex++;
//     }
// }
// Console.WriteLine($"Строка с наименьшей суммой элементов - строка {rowIndex}");
// Console.WriteLine($"Сумма элементов = {minSum}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы: 2 4 | 3 4  Результирующая матрица будет: 18 20
//                           3 2 | 3 3                                15 18

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstRows = number;
// int firstColumns = number;
// int secondRows = number;
// int secondColumns = number;
// int[,] firstArray = new int [firstRows,firstColumns];
// int[,] secondArray = new int [secondRows, secondColumns];

// FillArray(firstArray);
// PrintArray(firstArray);
// Console.WriteLine();
// FillArray(secondArray);
// PrintArray(secondArray);

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
// }
// void PrintArray (int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] result = new int[number,number];
// for (int i = 0; i < number; i++)
// {
//     for (int j = 0; j < number; j++)
//     {
//         for (int k = 0; k < number; k++)
//         {
//             result[i,j] += (firstArray[i, k] * secondArray[k, j]);
//         }
//     }
// }
// Console.WriteLine("Результат произведения массивов: ");
// PrintArray(result);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int rows = 2;
// int columns = 2;
// int deeps = 2;
// int start = 10;
// int[,,] numbers = new int [rows, columns, deeps];

//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             for (int k = 0; k < numbers.GetLength(2); k++)
//             {
//                 numbers[i,j,k] = start; 
//                 start ++;
//                 Console.Write($"{numbers[i,j,k]} ({i} {j} {k})      ");
//             }
//             Console.WriteLine();
//         }   
//     }
//     Console.WriteLine();






// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] numbers = new int[size, size];

int temp = 1;
int rows = 0;
int columns = 0;

while (temp <= numbers.GetLength(0) * numbers.GetLength(1))
{
  numbers[rows, columns] = temp;
  temp++;
  if (rows <= columns + 1 && rows + columns < numbers.GetLength(1) - 1) columns++;
  else if (rows < columns && rows + columns >= numbers.GetLength(0) - 1) rows++;
  else if (rows >= columns && rows + columns > numbers.GetLength(1) - 1) columns--;
  else rows--;
}
PrintArray(numbers);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
