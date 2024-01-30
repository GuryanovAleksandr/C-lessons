// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100) // Число минимум трехзначное от 100 до + бесконечности  
{
    int thirdDigitFromEnd = (number / 100) % 10;
    Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
}
else // В числе нет 3 цифры
{
    Console.WriteLine("Третьей цифры нет");
}