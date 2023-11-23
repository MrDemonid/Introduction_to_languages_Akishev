// подсчет количества цифр в числе

int getDigits(int num)
{
    int count = 0;

    if (num == 0)
        num++;
        
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("num = " + n + " of " + getDigits(n) + " digits");
