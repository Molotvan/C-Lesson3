Random random = new Random();
int x1 = random.Next(0, 10);
int y1 = random.Next(0, 10);
int z1 = random.Next(0, 10);
Console.WriteLine(" x1= " + x1 + " y1= " + y1 + " z1= " + z1);
int x2 = random.Next(0, 10);
int y2 = random.Next(0, 10);
int z2 = random.Next(0, 10);
Console.WriteLine(" x2= " + x2 + " y2= " + y2 + " z2= " + z2);
Console.WriteLine();
Console.WriteLine("Расстояние между точками = " + distance(x1, x2, y1, y2, z1, z2));

double distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

