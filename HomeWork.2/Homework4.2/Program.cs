/*
    Напишите программу, которая на вход принимает натуральное число N,
    а на выходе показывает его цифры через запятую:
	    9542 => 9, 5, 4, 2
*/

void showDigits(int num)
{
    int divider = 1000000000;

    while ((divider > 0) && (num / divider == 0))
    {
        divider /= 10;
    }
    if (divider == 0)       // если число равно нулю, то нужно вывести хотя бы ноль
        divider = 1;
    
    while (divider > 0)
    {
        Console.Write(num / divider);
        if (divider > 1)
        {
            Console.Write(", ");
        }
        num = num % divider;
        divider /= 10;
    }
    Console.WriteLine();
}

showDigits(92630);
showDigits(0);
showDigits(int.MaxValue);
showDigits(0xFE);
