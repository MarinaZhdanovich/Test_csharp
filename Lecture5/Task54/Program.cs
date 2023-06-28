/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

1) неявное преобразование double шире int
void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
}
*/
 /* 2) void FillArray(double[] array)
{
    int max = 100;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * max, 2); // [0, 1] - [0, max] 1 включительно
    }
}
*/
/* 3) void FillArray(double[] array)
{
    int deviation = 10;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2); //[-0.5, 0.5], *2 чтобы вернуть 1 [-1, 1]
    }
}
*/
/*
    4) void FillArray(double[] array)
{
    int min = -2;
    int max = 4;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2); 
    }
}
*/ 
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CraeteArray(int size)
{
    return new double[size];
}

void FillArray(double[] array)
{
    int min = -2;
    int max = 4;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2); 
    }  //[0, 1] затем *4-(-2) [0, 6], затем прибавили min  [-2, 4]
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double Diff (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++) // нулевую итерацию пропускаем
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i]; // взаимоисключающие условия поэтому else if
    }
    return Math.Round(max - min, 2);
}

int pos = InputNum("Введите размер массива: ");
double[] myArray = CraeteArray(pos);
FillArray(myArray);
PrintArray(myArray);

double difference = Diff(myArray);
Console.WriteLine(difference);