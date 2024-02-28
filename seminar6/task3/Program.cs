// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int GetVovelsCount(string str)
{
    // str = "hello", 'h' - 1 символ, char
    string vovels = "aeiouy"; // Гласные буквы в англ. алфавите
    int vovelsCount = 0; // Количество гласных
    foreach (char symbol in str) // Получает каждый символ введенной строчки
    {
        // 'a' == a, o, u, e, y, i
        foreach (char vovel in vovels) // Получаем гласные
        {
            if (symbol == vovel) // Нашли гласную букву
            {
                vovelsCount++; // vovelsCount = vovelsCount + 1
                break; // Если нашли гласную, переходим к след.букве
            }
        }
    }
    return vovelsCount;
}

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower(); // нижний регистр, "HI" -> "hi"
// ToUpper() - верхний ("hi" => "HI")
Console.WriteLine($"В строчке: {inputString} в нижн. регистре : {GetVovelsCount(inputString)} гласных");