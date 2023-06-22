/* Упорядочить данные в массиве. Алгоритм сортировки методом выбора. 
Найти позицию минимального элемента в неотсортированной части массива.
Произвести обмен этого значения со значением первой неотсортированной позиции.
Повторять пока есть неотсортированные элементы*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) // от отсортированного идем i + 1
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
array[i] = array[minPosition];
array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
