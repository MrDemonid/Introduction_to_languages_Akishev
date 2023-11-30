/*
    Найти наименьший элемент массива и обнулить
строку и столбец, в которой нахидится этот элемент.
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


int[,] SelectMin(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    int rowIndex = 0;
    int colIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[rowIndex, colIndex])
            {
                rowIndex = i;
                colIndex = j;
            }           
            result[i, j] = array[i, j];
        }
    }
    for (int i = 0; i < result.GetLength(0); i++)
    {
        result[i, colIndex] = 0;
    }
    for (int i = 0; i < result.GetLength(1); i++)
    {
        result[rowIndex, i] = 0;
    }
    return result;
}




Console.Clear();
int[,] array = CreateRandomMatrix(5, 5, 1, 9);
ShowIntMatrix(array);
Console.WriteLine();
int[,] mas = SelectMin(array);
ShowIntMatrix(mas);

