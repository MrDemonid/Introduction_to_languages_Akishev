/*
    Напишите программу, которая принимает на вход число N и
выдает произведение чисел от 1 до N.
Например:
    4 -> 24
    5 -> 120
*/

void Factorial(int num)
{
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        sum *= i;
    }
    Console.WriteLine($"Factorial {num} = {sum}");
}

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Factorial(n);
