/*
    Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
Вводить первое значение (m) больше 3-х не имеет смысла, очень быстро 
переполняется стек.
Да и для m==3 нужно быть аккуратнее с n, поскольку при n == 20 - нужно 
выполнить 94143178824 операций (m^(n+3)-3), из-за чего стек просто переполнится.
*/


/*
    Ввод корректного натурального числа с консоли.
*/
int EnterNaturalNum(string message)
{
    int res;
    
    while (true)
    {
        Console.Write("Enter param {0}: ", message);
        if (int.TryParse(Console.ReadLine(), out res))
            if (res >= 0)
                break;
        Console.WriteLine("The number must be positive or zero!");
    }
    return res;
}


/*
    Функция Аккермана
*/
int Akkerman(int m, int n)
{
    if (m == 0) 
        return n + 1;                                   // for (m == 0)
    else if (n == 0) 
        return Akkerman(m - 1, 1);                      // for (m > 0 && n == 0)
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));     // for (m > 0 && n > 0)
}


Console.Clear();
Console.WriteLine("Ackermann function f(m, n)");
int m = EnterNaturalNum("m");
int n = EnterNaturalNum("n");
Console.WriteLine($"Akkerman({m}, {n}) = {Akkerman(m, n)}");
