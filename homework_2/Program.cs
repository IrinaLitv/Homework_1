// Домашняя работа к семинару 2.

//  Задача 10
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = number / 10 % 10;
// if (number < 100 || number > 999) Console.WriteLine("Ошибка ввода!");
// else Console.WriteLine($"Вторая цифра числа {number} - это {result}");

// Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number < 100) Console.WriteLine($"Третьей цифры в числе {number} нет");
// if(number >= 100 && number <=999) 
// {
//     int result = number % 10;
//     Console.WriteLine($"Третья цифра в числе {number} - это {result}");
// }
// if (number > 999)
// {
//     string index = number.ToString();
//     Console.WriteLine($"Третья цифра в числе {index} - это {index[2]}");
// }


// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <= 5) Console.WriteLine("НЕ выходной");
if(number >=6 && number <= 7) Console.WriteLine("Выходной");
if(number > 7) Console.WriteLine("Ошибка ввода!");
