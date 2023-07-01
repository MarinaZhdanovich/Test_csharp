/* Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
            Console.Write($"{array[i, j]}\t"); //пробел или табуляция \t (на каждое значение 8 символов)
        }
        Console.WriteLine();
    }
}

int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i ==j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}
    

// int SumDiag(int[,] array) // альтернативная версия
// {
//     int sum = 0;
//     int temp = array.GetLength(1);  чтобы идти по наименьшему размеру
//     if (array.GetLength(0) < array.GetLength(1))    //Если количество элементов в строке меньше количества элементов в стобцах
//     {
//         temp = array.GetLength(0); // переприсваиваем temp
//     }
//     for (int i = 0; i < temp; i++)
//     {
//         sum += array[i, i];   //индекс строки равен индексу столбца, так как квадрат [0, 0], [1, 1], [2, 2]
//     }
//     return sum;
// }




int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимально значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int result = SumDiagonal(myArray);
Console.WriteLine(result);
