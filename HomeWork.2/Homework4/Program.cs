/*
    Напишите программу, которая на вход принимает натуральное число N,
    а на выходе показывает его цифры через запятую:
	    9542 => 9, 5, 4, 2
*/

void showDigits(int num)
{
    int[] digits = new int[10];
    int count = 0;

    Console.WriteLine("Source number: " + num);
    while (num != 0)
    {
        digits[count++] = num % 10;
        num /= 10;
    }

    while (count > 0)
    {
        Console.Write(digits[--count]);
        if (count != 0)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}


showDigits(9263);
showDigits(3);
showDigits(int.MaxValue);
showDigits(0xFE);


