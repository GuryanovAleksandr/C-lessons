// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81
using System.Globalization;

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 99 && number < 1000)
    {
        int firstDigit = number / 100; // 453 / 100 = 4
        int thirdDigit = number % 10; // 453 % 10 = 3
        int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43
        Console.WriteLine("Число без втрой цифры: " + result);
    }
else                                                            
    Console.WriteLine("Это не трехзначное число!");