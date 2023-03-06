int GetMultyply(int num)
{
    int mlp = 1;
    for (int i = 1; i<=num; i++)
    {
        mlp = mlp * i;
    }
    return mlp;
    
}
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());

int result = GetMultyply(a);
Console.Write(result);