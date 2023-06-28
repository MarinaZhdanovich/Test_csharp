/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
string count = "";

while (num > 0)
{
	// count = count + num % 2; //обратный порядок 01
	count = num % 2 + count; //поэтому остаток от деления впереди строки
	num = num / 2;     
}
Console.WriteLine(count);

//Например: 5
//=0 + ""
//=1 + 0
//=0 + 10
//=1 + 010


