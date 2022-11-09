// Написать программу, которая обменивает элементы первой строки и последней строки.
void FillArray(int[,] array, int m)
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
void ResultArray(int[,] array)
{
    int temp = 0;
    int a = 0;
    {
        for (int b = 0; b < array.GetLength(1); b++)
            {
                temp = array[a,b];
                array [a,b] = array[array.GetLength(0)-1, b];
                array [array.GetLength(0)-1, b] = temp; 
            }
    }
}

int a = 5;
int b = 5;
int[,] array = new int[a, b];

FillArray(array, a);
PrintArray(array);
Console.WriteLine();
ResultArray(array);
PrintArray(array);