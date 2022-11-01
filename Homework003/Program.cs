// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}
void Result(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a += 2)
    {
        for (int b = 0; b < array.GetLength(1); b += 2)
        {
            array[a, b] = array[a, b] * array[a, b];
        }
    }
}
int a = 3;
int b = 3;
int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Result(array);
PrintArray(array);