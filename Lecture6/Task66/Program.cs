//переворот массива


int[] array = {1, 2, 3, 4, 5};
Console.WriteLine(String.Join(" ", array));   //  вывод элементов массива на консоль в виде строки "1, 2, 3, 4, 5"

for (int i = 0; i < array.Length / 2; i++)
{
    array[i] = array[i] + array[array.Length - 1- i]; // сложили первый и последний, записали результат в array[i].
    array[array.Length - 1- i] = array[i] - array[array.Length - 1- i]; // вычитаем значение последнего элемента из нового значения array[i] и записываем результат в array[array.Length - 1 - i].
    array[i] = array[i] - array[array.Length - 1- i]; // вычитаем значение последнего элемента из временного значения array[array.Length - 1 - i] и записываем результат обратно в array[i].
}

//значения первого и последнего элементов массива поменялись местами

Console.WriteLine(String.Join(" ", array));
