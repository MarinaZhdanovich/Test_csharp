/*
Cортировка пузырьком
Начальный массив: [7, 6, 5, 4, 3, 2, 1]
*/
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n - 1; i++) // дополнительный цикл, чтобы все числа отсортировать (n - 1)
{
    for (int j = 0; j < n - 1 - i; j++)  // один цикл, чтобы поставить одно максимальное число в конец (n - 1), можно еще отнять - i чтобы не трогать отсортированные числа
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}

Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}]");

/*
Начальный массив: [7, 6, 5, 4, 3, 2, 1]

0[6, 5, 4, 3, 2, 1, 7]
1[5, 4, 3, 2, 1, 6, 7]
2[4, 3, 2, 1, 5, 6, 7]
3[3, 2, 1, 4, 5, 6, 7]
4[2, 1, 3, 4, 5, 6, 7]
5[1, 2, 3, 4, 5, 6, 7]

[1, 2, 3, 4, 5, 6, 7]
*/