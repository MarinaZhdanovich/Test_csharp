Console.Write("Введите число A: ");
string numberA = Console.ReadLine()!;
int numA = int.Parse(numberA);
Console.Write("Введите число B: ");
string numberB = Console.ReadLine()!;
int numB = int.Parse(numberB);

if (numA == numB * numB)
{
    Console.Write($"Число {numA} является квадратом числа {numB}");
}
else
{
    Console.Write($"Число {numA} не является квадратом числа {numB}");
}


// bool cheek = numA == numB * numB;
// Console.WriteLine(cheek);