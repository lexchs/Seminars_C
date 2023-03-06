

int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i<=num; i++)
    {
        sum = sum + i;
    }
    return sum;
    
}
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());

int result = GetSum(a);
Console.Write(result);