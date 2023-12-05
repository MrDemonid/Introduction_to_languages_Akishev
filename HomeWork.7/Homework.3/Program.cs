/*
    Задайте произвольную строку. Выясните,
    является ли она палиндромом.

“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да
*/



bool IsPalindrome(string msg)
{
    int len = msg.Length;
    for (int i = 0; i < len/2; i++)
    {
        if (Char.ToLower(msg[i]) != Char.ToLower(msg[len-i-1]))
            return false;
    }
    return true;
}

Console.Clear();
Console.Write("Enter string: ");
string msg = Console.ReadLine()+"";
if (IsPalindrome(msg))
{
    Console.WriteLine("String is palindrome!");
} else {
    Console.WriteLine("String is not palindrome!");
}
