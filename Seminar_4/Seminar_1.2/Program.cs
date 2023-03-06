int GetSum(int startNum, int endNum)
{
    int sum = 0;
    for (int i = startNum; i<=endNum; i++)
    {
        sum = sum + i;
    }
    return sum;
    
}
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());

int result = GetSum(1, a);
Console.Write(result);