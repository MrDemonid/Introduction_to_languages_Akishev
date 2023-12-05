/*
    Задайте двумерный массив символов (тип char[,]). 
    Создать строку из символов этого массива. 
a b c => “abcdef”
d e f 
*/

char[,] CreateCharMatrix(int rows, int cols)
{
    char[,] res = new char[rows, cols];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            res[i, j] = Convert.ToChar(rnd.Next('a', 'z'+1));
        }
    }
    return res;
}

void ShowCharMatrix(char[,] matrix)
{
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.Write($"row[{rows}]: ");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"'{matrix[rows, columns]}' ");
        }
        Console.WriteLine();
    }

}

string CharMatrixToString(char[,] matrix)
{
    string res = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            res += matrix[i,j];
        }
    }
    return res;
}

Console.Clear();
Console.Write("Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine()+"");
Console.Write("Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine()+"");
char[,] chr = CreateCharMatrix(rows, cols);
ShowCharMatrix(chr);

string msg = CharMatrixToString(chr);
Console.WriteLine($"result: '{msg}'");
