/* Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/


int Input(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int min, int max)
{
    Random rnd = new Random(); // создание экземпляра класса Random
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1); // [min, max) полуинтервал
    // array[i] = new Random().Next(min, max + 1)
}

string PrintArray(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += array[i] + " ";
    }
    return res;
}

void Rename(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = -array[i]; // или array[i] = -1 * array[i];
   }
}


int size = Input("Введите размер массива: ");
int minValue = Input("Введите минимальное значение элемента: ");
int maxValue = Input("Введите максимально значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);   

Rename(myArray);
string txtRename = PrintArray(myArray);
Console.WriteLine(txtRename);

