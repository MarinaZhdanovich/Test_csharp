Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = -1 * number;
while (start <= number)
{
    Console.Write($"{start}, ");
    start++;
}
