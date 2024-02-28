// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

char[] ConvertStringToCharArray(string str)
{
    char[] chars = new char[str.Length];
    // "hi" => [,], str.Length = 2, массив на 2 элемента
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
        //chars[0] = str[0], chars[0]=h
        //chars[1] = str[1], chars[1]=i
        // chars = ['h', 'i']
    }
    return chars;
    // str = "hi" => [h,i]
    // "hi" => [str[0], str[1]]
}
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
string Str = "Hello world!";
Console.WriteLine($"Исходная строка: {Str}");
char[] chars = ConvertStringToCharArray(Str);
Console.WriteLine($"Массив: [{string.Join("; ", chars)}]");