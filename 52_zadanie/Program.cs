// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
//Console.WriteLine();

// Функция для ввода значений от пользователя
int GetEnterAtribute(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
//*******************************************************************
int[,] GetArray(int r, int c, int minValueRand, int maxValueRand)
{
    int[,] result = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            result[i, j] = new Random().Next(minValueRand, maxValueRand + 1);
        }
    }
    return result;
}
//*******************************************************************
void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
//*******************************************************************

double[] GetSumCol(int[,] inArray)
{
    double sum = 0;
    double[] result = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j, i];
        }
        result[i] = Math.Round(sum / inArray.GetLength(0), 1);
        sum = 0;
    }
    return result;
}
//*******************************************************************

int rows = GetEnterAtribute("Введите количество строк: ");
int colum = GetEnterAtribute("Введите количество столбцов: ");
int minValMas = GetEnterAtribute("Минимальное значение массива: ");
int maxValMas = GetEnterAtribute("Максимальное значение массива: ");

int[,] result = GetArray(rows, colum, minValMas, maxValMas);
PrintArray(result);
Console.WriteLine($"Среднее арифметическое каждого столбца: [{String.Join(" ", GetSumCol(result))}]");
Console.WriteLine();