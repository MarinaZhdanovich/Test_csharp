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
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int temp = num;      // чтобы не обнулить num

int count = 0;
while (temp != 0)   //неизвестное количество итераций
{
    temp = temp / 10; // num /= 10;
    count++;
}

int[] array = new int[count];

for (int i = array.Length - 1; i >= 0; i--) //чтобы не был перевернутый
{
    array[i] = num % 10;
    num /= 10;
}

PrintArray(array);

Console.Write($"\n{array[2]}");  // переход на новую строку