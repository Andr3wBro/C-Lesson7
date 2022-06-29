// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GenerateArray(int row, int collums, int min, int max)
{
    double[,] array = new double[row, collums];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
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
            System.Console.Write($"{array[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int row = Prompt("Number of rows => ");
int collums = Prompt("Number of collums => ");
int min = Prompt("Min of array => ");
int max = Prompt("Max of array => ");

double[,] myArr = GenerateArray(row, collums, min, max);
PrintArray(myArr);