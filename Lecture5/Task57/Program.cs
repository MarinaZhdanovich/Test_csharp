/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
9/2 = 4 остаток 1, 4/2 = 2 остаток 0, 2/2 = 1 остаток 1 = 1001
3/2 = 1 остаток 1 = 11 переписываем с конца
2/2 = 1 остаток 0 = 10
*/ 



int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] Division (int num)
{
    int temp = num;
    int count = 0; //количество делений на 2/разрядов для построения массива
    int res = 0; // сохраняем остатки
    while(temp != 0)
    {
        temp = temp / 2;  
        count++;
    }
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        res = num % 2;
        num = num / 2;
        array[i] = res; // собираем в массив остатки
    }
    return array;
}

void RevArray(int[] array) // переворачиваем
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

int number = InputNum("Введите число: ");
int[] myArray = Division(number);
PrintArray(myArray);
RevArray(myArray);
PrintArray(myArray);