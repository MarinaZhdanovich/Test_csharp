int[] SortQuick(int[] array, int left, int right) //индекс левой границы 0 и индекс правой границы длина - 1
{
    int i = left;  //индекс, который будет двигаться с левого края к правому краю массива
    int j = right; //индекс, который будет двигаться с правого края к левому краю массива

    int pivot = array[Random.Shared.Next(left, right)];  //опорный элемент, случайный элемент из текущего подмассива
    while (i <= j)
    {
        while (array[i] < pivot) i++;   // элементы с индексами слева от i  меньше опорного элемента
        while (array[j] > pivot) j--;  //элементы с индексами справа от j были больше опорного элемента

        if (i <= j)
        {
            int t = array[i];
            array[i] = array[j];  //Если индекс i меньше или равен j, то это означает, что элемент array[i] больше или равен опорному элементу, а элемент array[j] меньше или равен опорному элементу. 
            array[j] = t;  // элементы меняются местами, чтобы правильно разделить подмассив.
            i++;
            j--;
        }
    }
    if (i < right) SortQuick(array, i, right); //после разделения массива на две части относительно опорного элемента, функция вызывается рекурсивно для обеих половинок.
    if (left < j) SortQuick(array, left, j);
    return array;
}

int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");

SortQuick(array, 0, array.Length - 1);
Console.WriteLine("Отсортированный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");