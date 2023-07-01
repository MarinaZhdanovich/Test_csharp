/* Задайте двумерный массив размера m на n, каждый элемент
 в массиве находится по формуле: Aₘₙ = m+n. 
 Выведите полученный массив на экран.
 m и n - номера индексов
 2 и 4 = 6
 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            array[i, j] = i + j;
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t"); //пробел или табуляция \t (на каждое значение 8 символов)
        }
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");


int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);