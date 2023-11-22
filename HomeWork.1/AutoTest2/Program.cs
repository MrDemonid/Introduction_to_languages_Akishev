int a = 5;
int b = 7;
int c = 8;

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
System.Console.WriteLine($"{max}");
