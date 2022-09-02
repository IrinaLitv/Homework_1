// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число М: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// if(numberM > numberN) return;

// int SumNumbers (int numberM, int numderN )
// {
//     if (numberM == numberN) return numberM;
//     return (numberM + SumNumbers(numberM + 1, numberM));
// }
// Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {SumNumbers(numberM,numberN)}");




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите первое положительное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber < 0 || secondNumber < 0) return;

int FunctionAkkerman (int firstNumber, int secondNumber )
{
    if (firstNumber == 0) return secondNumber + 1;
    if (secondNumber == 0 && firstNumber !=0) return FunctionAkkerman(firstNumber - 1, 1);
    return FunctionAkkerman(firstNumber - 1, FunctionAkkerman(firstNumber, secondNumber - 1));
}
Console.WriteLine($"Функция Аккермана для чисел {firstNumber} и {secondNumber} = {FunctionAkkerman (firstNumber, secondNumber)}");
