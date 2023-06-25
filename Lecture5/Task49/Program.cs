string[,] table = new string [2, 5];  // 2 строки, 5 столбцов
// table [0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4] до 4 так как начинаем с 0
// table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4] 
// до 1 так как начинаем с 0
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
Console.WriteLine();
}