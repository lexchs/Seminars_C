Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if(num>99)
{
    while(num>=999)
    {
        num /= 10;
    }
    int res = num % 10;
    Console.Write($"Third digit is: {res}");
}
else
{
    Console.Write("No third digit");
}