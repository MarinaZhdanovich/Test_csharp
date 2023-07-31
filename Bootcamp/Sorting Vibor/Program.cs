// Сортировка Выбором

/*
2 7 0 3 -5 12 8

-5 7 0 3 2 12 8

-5 0 7 3 2 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 12 8

-5 0 2 3 7 8 12
*/
// char f()  // -> функция
// {
//     return '1';
// }

// void v()  // -> процедура
// {
//     Console.WriteLine("Hello, world!");
// }

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11); // [-10; 10]
}


int[] SortVibor(int[] array) // [2 7 0 3 -5 12 8]
{
    for (int i = 0; i < array.Length - 1; i++) // последний элемент не с чем сравнивать поэтому - 1
    {
        int min = i; //предполагаемый минимум i = 0 -> 2
        for (int j = i + 1; j < array.Length; j++) // j = 1 -> 7
        {
            if (array[j] < array[min]) // элемент
            {
                min = j; // индекс массива
            }
        }
        int temp = array[min]; // мин элемент массива
        array[min] = array[i];
        array[i] = temp;
    }
    return array;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", SortVibor(array))}]");