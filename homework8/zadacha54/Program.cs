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
            array[i, j] = new Random().Next(1, 9);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
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


void uporyadok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                    Console.Write(array[i, k] + " ");

                }
            
            }
            
        }
   
    }
     Console.WriteLine();
}

uporyadok(array);
Console.WriteLine("Отсортированный массив:");
printm(array);