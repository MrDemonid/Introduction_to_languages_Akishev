/*
    Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, 
сумма цифр которого чётная.
*/

/*
  подсчитывает сумму цифр числа
*/

/*
    подсчитывает сумму цифр числа, как для положительных, так и для отрицательных
*/
int NumToSumDigits(int number)
{
    int sum = 0;

    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return int.Abs(sum);
}

/*
    собственно задание
*/
void Loop()
{
    while (true)
    {
        Console.Write("Enter integer number or 'q' for exit: ");
        string str = Console.ReadLine();
        if (str != null)
        {
            if (str.ToLower() == "q")
                break;
        }
        int num;
        if (int.TryParse(str, out num))
        {
            num = NumToSumDigits(num);
            if ((num & 0x01) == 0)
            {
                Console.WriteLine("Sum of digits is even!");
                break;
            }
        } else {
            Console.WriteLine("Bad number!");
        }
    }
    Console.WriteLine("[STOP]");
}


Console.Clear();
Loop();
