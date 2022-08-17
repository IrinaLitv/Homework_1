// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень числа: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = numberA;
// for (int i = 1; i < numberB; i++)
// {
//     result = result * numberA;
// }

// Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int GetSum (int num)
// {
//     int sum = 0;
//     while (num > 0)
//     {
//         int res = num % 10;
//         sum = sum + res;
//         num = num/10;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма цифр в числе {N} = {GetSum(N)}");







// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = new int [8];
for (int i = 0; i < 8; i++)
{
    arr [i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Массив: [{String.Join(",", arr)}]");

