/*
    Напишите программу, которая принимает на вход число N и
выдаёт таблицу квадратов чисел от 1 до N.
Например:
    5 -> 1, 4, 9, 16, 25
    2 -> 1, 4
*/

void PrintSquareTbl(int num)
{
    if (num == 0)
    {
        Console.WriteLine("Number must be greater than 0");
        
    } else {
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i*i);
            if (i < num)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintSquareTbl(n);
