// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
void FillArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            array[a, b] = new Random().Next(1, 50);
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
int a = 5;
int b = 5;
int[,] array = new int[a, b];

FillArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
string Position(int[,] array)
{
    string result = string.Empty;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            if (number == array[a, b]) result += $"У введенного вами числа {number} позиция ({a}, {b})";
        }
    }
    if (result == string.Empty) result = "Такого элемента нет";
    return result;
}
Console.Write(Position(array));