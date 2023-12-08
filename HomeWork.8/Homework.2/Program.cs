/*
    Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
//m=2, n = 3 -> A(m,n)=29
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman(int m, int n)
{
    if (m == 0) 
        return n + 1;
    else if (n == 0) 
        return Akkerman(m - 1, 1);
    else 
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = 2;
int n = 3;
Console.WriteLine($"Akkerman({m}, {n}) = {Akkerman(m, n)}");
m = 3;
n = 2;
Console.WriteLine($"Akkerman({m}, {n}) = {Akkerman(m, n)}");
