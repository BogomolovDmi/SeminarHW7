// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 100);
        }
    }
    return result;
}
Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}
var array = CreateArrayWithRandomNumbers(m, n);
PrintArray(array);

Console.WriteLine("Введите индекс строки искомого числа");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца искомого числа");
int column = Convert.ToInt32(Console.ReadLine());

if (line > m || column > n)
{
    Console.WriteLine("такого числа в массиве нет");
}
else
{
    object number = array.GetValue(line, column);
    Console.WriteLine("Искомое число = " + number);
}
