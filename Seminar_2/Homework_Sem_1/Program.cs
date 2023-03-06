Console.Write("Enter a three-digit number: ");
int num = int.Parse(Console.ReadLine());

if (Math.Abs(num) >99 & Math.Abs(num) <= 999)
{
    int numb = num % 100;
    int res = numb / 10;
    Console.Write($"The second digit is: {Math.Abs(res)}");
}
else
{
    Console.Write("It's not a three digit number ;(");
}