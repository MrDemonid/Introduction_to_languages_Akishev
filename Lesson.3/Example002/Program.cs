// Вывести четные числа в промежутке заданные пользователем

void ShowEven(int first)
{
    if (first % 2 == 0)
    {
        Console.Write(first + " ");
    }
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
    ShowEven(first++);
}
