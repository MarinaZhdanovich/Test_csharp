/* Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
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

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();  // экземпляр класса рандом
    for (int i = 0; i < array.GetLength(0); i++) //строки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            array[i, j] = rnd.Next(min, max + 1); //чтобы было включительно
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
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимально значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray,minValue, maxValue);
Print2DArray(myArray);
