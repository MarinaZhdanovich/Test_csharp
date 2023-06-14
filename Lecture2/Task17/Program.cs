void FillArray(int [] collection)   // метод не возвращает
{
    int length = collection.Length; //длина массива
    int index = 0; //позиция
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // 0 - сохраняем позицию, -1 - если элемента нет 
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index; // в позицию значение индекса
            break; //так как находит последнее вхождение, сейчас будет первое
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // создает массив с 10 элементами, по умолчанию будут нули
// определилили

FillArray(array); // заполнили массив
PrintArray(array); // распечатали массив
Console.WriteLine(); // не является частью вывода массива

int pos = IndexOf(array, 45); 
Console.WriteLine(pos);
