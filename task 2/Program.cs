// Напишите программу, которая принимает на вход трёхзначное число 
// и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int seсondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4 
int thirdDigit = number % 10; // 947 % 10 = 7 
int result = (int)Math.Pow(seсondDigit, thirdDigit);  // Math.Pow(4, 7) => 4^7 = 16384 // Результат переводится в (int)
Console.WriteLine($"{seсondDigit} ^ {thirdDigit} = {result}"); // 4 ^ 7 = 16384