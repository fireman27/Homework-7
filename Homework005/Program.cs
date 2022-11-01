// В матрице чисел найти сумму элементов главной диагонали

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
int Sum(int[,] array)
{
    int sum = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        sum += array[a, a];
    }
    return sum;
}

int a = 5;
int b = 5;

int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Сумма элементов главной диагонали равна: " + Sum(array));
