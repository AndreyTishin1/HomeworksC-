/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

void oddPosithion(int colElements)
{
    int[] array = new int[colElements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
        Console.Write(array[i] + " ");
    }

    int summOdd = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summOdd = summOdd + array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine( $"Сумма элементов массива, стоящих на нечетных позициях равна {summOdd}");
}

Console.WriteLine("задайте число элементов массива: ");
int colElements = int.Parse(Console.ReadLine());
oddPosithion(colElements);