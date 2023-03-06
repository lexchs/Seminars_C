/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void ShowCubeList(int n)
{
    for(int i = 1; i <= n; i++)
    {
        double result = Math.Pow(i,3);
        Console.Write($"{result} " );
    }
}
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());
ShowCubeList(num);