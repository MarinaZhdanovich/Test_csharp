int[] InputSomeNums()   // вернуть два числа, два return нельзя
{
    Console.Write("Введите количество чисел: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    
    for(int i = 0; i < array.Length; i++) //
    {
        Console.Write($"Введите {i + 1}-е число: "); // порядковый номер, чтобы пользователь понимал, что это первое, второе итд.
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) // (for лупа)индекс, условие, инкремент
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)  // все элементы кроме последнего
            Console.Write(", ");
        else
            Console.Write(".");
    }
}

int[] myArray = InputSomeNums();
PrintArray(myArray);