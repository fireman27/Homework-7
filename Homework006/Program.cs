// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(1, 20);
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
string Averagevalue(int[,] array)
{
    string result = string.Empty;
    for (int b = 0; b < array.GetLength(1); b++)
    {
        int summ = 0;
        int count = 0;
        double middle = 0;
        for (int a = 0; a < array.GetLength(0); a++)
        {
            summ += array[a, b];
            count++;
        }
        middle = summ / count;
        Console.Write($"{middle} ");
    }
    return result;
}
int a = 5;
int b = 5;
int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(Averagevalue(array));