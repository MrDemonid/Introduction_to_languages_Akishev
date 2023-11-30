/*
    Сформировать одномерный массив из двухмерного, где первый элемент - это
среднее арифметическое элементов первой строки двухмерно массива, второй - 
второй строки и тд.
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
    вывод на экран двухмерного массива чисел (int)
*/
void ShowFloatMatrix(float[] array)
{
    Console.WriteLine();
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        Console.Write($"[{array[rows]}] ");
    }
    Console.WriteLine();
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


float[] AverageArray(int[,] array)
{
    float[] res = new float[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        float sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        res[i] = sum / array.GetLength(1);
    }
    return res;
}


Console.Clear();
int[,] array = CreateRandomMatrix(5, 5, 1, 9);
ShowIntMatrix(array);
float[] mas = AverageArray(array);
ShowFloatMatrix(mas);
