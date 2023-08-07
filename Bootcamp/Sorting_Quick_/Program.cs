int[] QuickSort(int[] array)
{
    if (array.Length <= 1)
    {
        return array;
    }
    else
    {
        int pivot = array[0];
        int[] left = array.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = array.Skip(1).Where(x => x >= pivot).ToArray(); //однострочник
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}
// После того, как левый подмассив был отсортирован, опорный элемент pivot добавляется в результирующий массив. 
// В этой строке pivot оборачивается в новый массив типа int, чтобы можно было использовать метод Concat.
// метод ToArray() преобразует последовательность элементов, полученных после объединения левого подмассива, 
// опорного элемента и правого подмассива, в новый одномерный массив.
int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] result = QuickSort(array);
Console.WriteLine("Отсортированный массив:");
Console.WriteLine($"[{String.Join(", ", result)}]");