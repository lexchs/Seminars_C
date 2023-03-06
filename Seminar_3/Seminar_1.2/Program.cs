double GetDistance(int x1, int y1, int x2, int y2)
{
   double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
   return result;
}

Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());

double res = GetDistance(x1, y1, x2, y2);
Console.Write(Math.Round(res,2,MidpointRounding.ToNegativeInfinity));
