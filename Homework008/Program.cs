// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int Summ(int[,] array)
{
    int minSum = 0;
    int index = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        int sum = 0;
        for (int b = 0; b < array.GetLength(1); b++)
        {
            sum = sum + array[a, b];
        }
        if (a == 0) 
            minSum = sum;
        else if (sum < minSum)
        {
            minSum = sum;
            index = a;
        }
    }
    return index;
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Cтрока с наименьшей суммой элементов (первая строка это 0): " + Summ(array));