// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



void maxmin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double raz = max - min;
    Console.WriteLine();
    Console.WriteLine($"Минимальное значение элемента в массиве равно {min}");
    Console.WriteLine($"Максимальное значение элемента в массиве равно {max}");
    Console.WriteLine($"Раздница между максимальным и минимальным равна {raz}");
}

    Console.WriteLine("Введите количество элементов массива: ");
    int kolElements = int.Parse(Console.ReadLine());
    double[] array = new double[kolElements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 20;
        array[i] = Math.Round((array[i]), 2);
        Console.Write(array[i] + " ");
    }
    maxmin(array);

