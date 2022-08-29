// Домашняя работа к семинару 6.

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел вы хотите ввести? ");
// int count = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[count];

// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine("Введите положительное или отрицательное число: ");
//     numbers [i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"[{String.Join(",", numbers)}]");
// int positiveNumbers = 0;
// for (int i = 0; i < count; i++)
// {
//     if (numbers[i] >0) positiveNumbers += 1;
// }
// Console.WriteLine($"Положительных чисел - {positiveNumbers}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double xGeneral = (b2 - b1)/(k1 - k2);
// double yGeneral = k1 * xGeneral + b1;

// Console.WriteLine($"Точка пересечения - ({xGeneral}, {yGeneral})");


// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
string result = "";
while (decimalNumber > 0)
{
    result = ((decimalNumber % 2 ==0)? "0" : "1") + result;
    decimalNumber = decimalNumber / 2;
}
Console.Write(result);
Console.WriteLine();