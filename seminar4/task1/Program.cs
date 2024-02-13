// тип_метода ИмяМетода (пар1, пар2, ... парN)
// a, b - 2 числа, sign - знак арифм. операции
int Calculate(int a, int b, string sign)
{
    if (sign == "+")
    {
        return a + b; // Cумма чисел
    }
    else if (sign == "-")
    {
        return a - b; // Разность чисел
    }
    else if (sign == "*")
    {
        return a * b; // Произ-е чисел
    }
    else
    {
        Console.WriteLine("Введен неизвестный знак арифм. операции");
        return 0;
    }
}

// Вызов метода
Console.WriteLine(Calculate(2, 3, "+")); // 5
Console.WriteLine(Calculate(2, 3, "-")); // -1
Console.WriteLine(Calculate(20, 3, "*")); // 60
Console.WriteLine(Calculate(20, 3, ".")); // 60