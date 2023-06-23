/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double rast(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return d;
}

Console.WriteLine("Введите координаты точки x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки z2");
int z2 = int.Parse(Console.ReadLine());

double d = rast(x1, y1, z1, x2, y2, z2);
d = Math.Round(d, 2);
Console.WriteLine($"Расстояние между точками = {d} ");
