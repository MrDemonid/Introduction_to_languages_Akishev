/*
    Напишите программу, уоторая принимает на вход целое число из
    отрезка [10..99] и показывает наибольшую цифру числа
    Решение: решение подразумевает одно деление числа на 10 и одно взятия остатка,
             но через цикл красивее :)
*/

int MaxDigit(int number)
{
    int max = 0;
    while (number != 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit > max)
        {
            max = digit;
        }
    }
    return max;
}

int num = 98;
 
Console.WriteLine("Source = " + num);
Console.WriteLine($"Max digit is {MaxDigit(num)}");
