/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble() * 20),2);
        Console.Write(array[i, j] + " ");
    }
Console.WriteLine();        
}


