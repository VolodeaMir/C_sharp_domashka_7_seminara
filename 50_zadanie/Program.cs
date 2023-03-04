// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();

Console.WriteLine();

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



//*******************************************************************

int rows = GetEnterAtribute("Введите количество строк: ");
int colum = GetEnterAtribute("Введите количество столбцов: ");
int minValMas = GetEnterAtribute("Минимальное значение массива: ");
int maxValMas = GetEnterAtribute("Максимальное значение массива: ");
int x = GetEnterAtribute("Введите индекс строки: ");
int y = GetEnterAtribute("Введите индекс столбца: ");

int[,] result = GetArray(rows, colum, minValMas, maxValMas);
PrintArray(result);
Console.WriteLine();

if ((x >= rows) || (y >= colum))
{
    Console.WriteLine($"По индексу [{x}, {y}] нет элемента");
}
else
{
    Console.WriteLine($"По индексу [{x}, {y}] находится элемент = {result[x, y]}");
}

Console.WriteLine();