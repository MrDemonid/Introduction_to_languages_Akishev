/*
    Задайте строку, состоящую из слов, разделенных пробелами. 
    Сформировать строку, в которой слова расположены в обратном порядке. 
    В полученной строке слова должны быть также разделены пробелами.

    “Hello my world” => “world my Hello”

    Два варианта.
    1) Простым сканированием строки с конца (закоментирована).
    2) Рекурсия.
*/


/*
//    Возвращает слово из строки, с позиции pos, до первого пробела
//    
string GetWord(string str, int pos, int len)
{
    string res = "";
    while (len > 0 && pos < str.Length)
    {
        if (str[pos] == ' ')
            break;
        res += str[pos];
        len--;
        pos++;
    }
    return res;
}

// Перестановка слов в строке в обратном порядке. Лишние пробелы обрезаются.
//
string InverseString(string msg)
{
    string res = String.Empty;
    string word;
    int len = 0;

    for (int i = msg.Length-1; i >= 0; i--)
    {
        if (msg[i] == ' ')
        {
            word = GetWord(msg, i+1, len);
            if (word.Length > 0)
            {
                if (res.Length > 0)
                    res += " ";
                res += word;
            }
            len = 0;
        } else {
            len++;
        }
    }
    word = GetWord(msg, 0, len);    // присоединяем возможный остаток строки
    if (word.Length > 0)
        res = res + " " + word;
    return res;
}

*/


/*
    Перестановка слов в строке в обратном порядке. Лишние пробелы игнорируются.
*/
string InverseString(string msg, int pos)
{
    string res = "";

    if (pos < msg.Length)   // базовая функция
    {
        // удаляем ведущие пробелы
        while (msg[pos] == ' ')
        {
            if (++pos >= msg.Length)
                break;
        }
        // выбираем очередное слово
        for (int i = pos; i < msg.Length; i++)
        {
            if (msg[i] == ' ')
            {
                string next = InverseString(msg, i);
                if (next.Length > 0)
                    res = next + " " + res;
                break;
            } else {
                res += msg[i];
            }
        }

    }
    return res;
}


Console.Clear();
Console.WriteLine("Enter string:");
string msg = Console.ReadLine()+ "";

Console.WriteLine($"{InverseString(msg, 0)}");
