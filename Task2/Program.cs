// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int SearchAndFindElement(int[,]array, int i, int j)
{
    if(i>array.GetLength(0) || j>array.GetLength(1) ) Console.WriteLine("Element not exist");
    return array[i-1,j-1];
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] myArr = GenerateArray(5,5,0,10);
PrintArray(myArr);
Console.WriteLine();
int i = Prompt("Enter row position => ");
int j = Prompt("Enter collum position => ");
Console.WriteLine($"Element in this position is => {SearchAndFindElement(myArr,i,j)}");