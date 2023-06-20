/* Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ArrayRand(int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2); // next(2)
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int len = InputNum("Введите длину массива: ");
int [] arr = ArrayRand(len);
PrintArray(arr);
