Console.Clear();

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double pointX;
double pointY;

if  (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    pointX = (double) (b2-b1)/(k1-k2);
    pointY = (double) k1*(b2-b1)/(k1-k2) + b1;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.0}");
    Console.WriteLine($"Y: {pointY:0.0}");
}