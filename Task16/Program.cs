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
int [] array = new int [10]; // создает массив с 10 элементами, по умолчанию будут нули
// определилили

FillArray(array); // заполнили массив
PrintArray(array); // распечатали массив