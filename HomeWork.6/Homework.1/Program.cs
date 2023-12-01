/*
    Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же 
указание, что такого элемента нет.
*/


/*
    вывод на экран двухмерного массива чисел (int)
*/
void ShowIntMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.Write($"row[{rows}]: ");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"[{matrix[rows, columns]}] ");
        }
        Console.WriteLine();
    }
}

/*
    создание двухмерного массива чисел, с заполнением случайными значениями
*/
int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(min, max+1);
        }
    return result;
}


/*
    вводим данные для создания массива
*/
Console.Clear();
Console.Write($"Enter rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomMatrix(rows, cols, min, max);
ShowIntMatrix(array);
/*
    получаем элемент
*/
Console.Write($"Enter row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter col: ");
int col = Convert.ToInt32(Console.ReadLine());
if (row < 0 || col < 0 || row >= array.GetLength(0) || col >= array.GetLength(1))
{
    Console.WriteLine($"Index [{row}, {col}] out of range!");
} else {
    Console.WriteLine($"Elem[{row}, {col}] = {array[row, col]}");
}
