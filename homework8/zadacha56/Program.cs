//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];

void massiv(int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void printm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

massiv(m, n);
Console.WriteLine("Исходный массив:");
printm(array);


int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    if (sum > SumLine(array, i))
    {
        sum = SumLine(array, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

