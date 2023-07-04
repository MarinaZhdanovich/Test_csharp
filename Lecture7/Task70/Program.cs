/*
Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
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
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
int[] MinNum(int[,] array)
{
    int minN = array[0, 0];   //первого элемент
    int[] index = new int[2];  // два значения index[0]- индекс строки, index[1] - индекс столбца
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minN)  // находим значение меньше текущего значения minN, обновляем minN
            {
                minN = array[i, j];
                index[0] = i;
                index[1] = j;  //сохраняем индексы этого элемента в массиве index
            }
        }
    }
    return index;
}
int[,] ChangeArray (int [,] array, int [] index)
{
    int [,] ChangedArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];   // создаем новый массив с размерами на 1 единицу меньшими, чем размеры исходного массива
    int row = 0;
    int col = 0;
    for (int i = 0; i < array.GetLength(0); i++)   // выполняем копирование элементов из исходного массива в новый 
    {
        if (i == index[0]) continue; // если значение переменной i равно значению в массиве index - пропускаем текущую итерацию и переходим к следующей итерации
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == index[1]) continue;
            ChangedArray[row,col] = array[i,j];
            col++;            // указание следующего столбца, куда будет скопирован следующий элемент
        }
        col = 0; // после завершения цикла по столбцам, сбрасываем до 0
        row++; // переходим на след строку
    }
    return ChangedArray;
}
int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int[] minimum = MinNum(myArray);
int[,] resultArray = ChangeArray(myArray,minimum);
Print2DArray(resultArray);