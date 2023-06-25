// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void massiv(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(0,15);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
massiv(number);