/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int InputNum(string message)
{
    Console.Write(message);
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
        res += array[i] + " ";
    return res;
}

int[] MultPairs(int[] array)
{
    int[] newArr = new int[array.Length / 2 + array.Length % 2];  //Создаем новый массив с размером, равным половине длины массива array + остаток от деления длины на 2 (если нечетный массив)
    for (int i = 0; i < array.Length / 2; i++)   //выполняем до половины длины исходного массива
    {
        newArr[i] = array[i] * array[(array.Length - 1) - i];  // вычисляем произведения элементов, произведение сохраняем в индексе newArr.
    }
    if (array.Length % 2 == 1) //если массив нечетный.
    {
        newArr[newArr.Length - 1] = array[array.Length / 2]; //последний элемент нового массива = элементу в середине. Целочисленное деление!!! если из 5 / 2 = 2 - это индекс
    }
    return newArr;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
string txt = PrintArray(myArray);
Console.WriteLine(txt);

int[] newArray = MultPairs(myArray);
txt = PrintArray(newArray);
Console.WriteLine(txt);



//array = [10, 20, 30, 40, 50]
// array[(array.Length - 1) - i] 

// i = 0:
// array.Length = 5. -> (array.Length - 1) - i будет (5 - 1) - 0, что равно array[4] - 50

// i = 1:
// (array.Length - 1) - i будет (5 - 1) - 1, что равно array[3] - 40,

// i = 2:
// (array.Length - 1) - i будет (5 - 1) - 2, что равно array[2] - 30.