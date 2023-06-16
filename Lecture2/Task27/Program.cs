int [] InputSomeNums()  // получение двух чисел
{
    int[] twoNums = new int[2]; // массив из 2 чисел, заполнен 0
    Console.Write("Enter the first number: ");
    twoNums[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the second number: ");
    twoNums[1] = int.Parse(Console.ReadLine()!);
    return twoNums;
}

int[] array = InputSomeNums();
Console.WriteLine($"{array[0]}, {array[1]}");

