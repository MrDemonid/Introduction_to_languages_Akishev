// Вывести четные числа в промежутке заданные пользователем

int ShowEven(int first)
{
    if (first % 2 == 0)
    {
        return first;
    }
    return 0;
}


Console.WriteLine("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    int temp = second;
    second = first;
    first = temp;
}

while (second >= first)
{
    int res = ShowEven(first++);
    if (res != 0)
        Console.Write(res + " ");
}
