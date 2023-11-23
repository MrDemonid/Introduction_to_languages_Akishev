// программа принимает на вход число и выдает сумму от 1 до N

int NumFunc(int num)
{
    int res = 0;

    for (int count = 1; count <= num; count++)
    {
        res += count;
    }
    return res;
}

Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n + " = " + NumFunc(n));
