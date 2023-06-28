/* Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CraeteArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++) // идем до середины
    {
        int temp = array[i]; // сохраняем во вспомогательную переменную значение текущего элемента чтобы не потерять
        array[i] = array[array.Length -1 - i]; //поменяли
        array[array.Length -1 - i] = temp; // последнему присваиваем первое значение
    }
}
// //array = [10, 20, 30, 40, 50]
// array[(array.Length - 1) - i] 

// i = 0:
// array.Length = 5. -> (array.Length - 1) - i будет (5 - 1) - 0, что равно array[4] - 50

// i = 1:
// (array.Length - 1) - i будет (5 - 1) - 1, что равно array[3] - 40,

// i = 2:
// (array.Length - 1) - i будет (5 - 1) - 2, что равно array[2] - 30.

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение: ");
int maxValue = InputNum("Введите максимальное значение: ");

int[] myArray = CraeteArray(size);
FillArray(myArray, minValue, maxValue);
PrintArray(myArray);
ReverseArray(myArray);
PrintArray(myArray);