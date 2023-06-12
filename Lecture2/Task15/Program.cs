int [] array = {1, 12, 31, 4, 15, 16, 17, 15, 18};

int n = array.Length; // количество элементов массива
int find = 15; //элемент 15
int index = 0; //позиция 4

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //находит только первый повторяющийся элемент
    }
    index++;
}
