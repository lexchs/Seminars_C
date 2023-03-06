void ShowSqr(int n)
{
    for(int i = 1; i <= n; i++)
        {
            double res = Math.Pow(i,2);
            Console.Write($"{res}, ");
        }
}
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
ShowSqr(num);