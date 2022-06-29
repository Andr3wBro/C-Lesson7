// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    Console.Write("\t");
    for (int e = 0; e <array.GetLength(1); e++)
    {
        Console.Write($"Col {e + 1}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Row {i + 1}\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void AverageInCollum(int[,] array)
{
    double averajecollum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            averajecollum += array[i, j];
        }
        averajecollum /= array.GetLength(1);
        Console.WriteLine($"Average in collum {j + 1} => {averajecollum:f2}");
        averajecollum = 0;
    }
}

int[,] myArray = GenerateArray(5, 5, 1, 10);
PrintArray(myArray);
AverageInCollum(myArray);