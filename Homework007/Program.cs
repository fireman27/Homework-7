// Написать программу, которая обменивает элементы первой строки и последней строки.
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
Console.WriteLine();
int ResultArray(int[,] array)
{
    int m = 0;
    for (int a = 0; a < array.GetLength(1); a++)
    {
        m = array[array.GetLength(0) - 1, a];
        array[array.GetLength(0) - 1, a] = array[0, a];
        array[0, a] = m;
    }
        for (int a = 0; a < array.GetLength(0); a++)
        {
            for (int b = 0; b < array.GetLength(1); b++)
            {   
                Console.Write(array[a, b] + " ");
            }
        Console.WriteLine();
        }
    return m;
}

int a = 5;
int b = 5;
int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ResultArray(array);