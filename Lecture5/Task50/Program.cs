void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)  // 0 - строка
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // 1 столбец
        {
            Console.Write($" {matr[rows, columns]} "); //дополнительно поставили пробел
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
