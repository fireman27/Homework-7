// Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("введите количество строк");
int lines = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите количество столбцов");
int columns = int.Parse(Console.ReadLine() ?? "0");
int[,] numbers = new int[lines, columns];

void FillArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
FillArrayNumbers(numbers);
PrintArray(numbers);