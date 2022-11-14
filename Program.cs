/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(0, 10);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}      ");
        }
        Console.WriteLine();
    }
}

void SumMinRow(int[,] matrix)
{
    int minRowInd = 0; // инд строки с мин суммой
    int minSumRow = 0; // строка с мин суммой
    int sum = 0; // мин сумма строки
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRowInd += matrix[0,i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < minRowInd)
        {
            minRowInd = sum;
            minSumRow = i;
        }
        sum = 0;    
    }
    Console.Write($"{minSumRow + 1} строка");
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m, n);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
SumMinRow(matrix);
Console.WriteLine();