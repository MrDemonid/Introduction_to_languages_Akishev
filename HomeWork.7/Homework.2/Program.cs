/*
    Задайте строку, содержащую латинские буквы
    в обоих регистрах. Сформируйте строку, в которой все
    заглавные буквы заменены на строчные. 
    “aBcD1ef!-” => “abcd1ef!-” 
*/

string StringToLower(string msg)
{
    string res = String.Empty;

    for (int i = 0; i < msg.Length; i++)
    {
        res += Char.ToLower(msg[i]);
    }
    return res;
}


Console.Clear();
Console.WriteLine("Enter string with lower and upper symbols: ");
string str = Console.ReadLine()+"";
Console.WriteLine(StringToLower(str));
