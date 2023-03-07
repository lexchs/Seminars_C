/*Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int AdditionOfNumbers(int a)
{
    int num = a;
    int sum = 0;
    int dig = 0;
    while(num>0)
    {
        dig = num % 10;
        num = num / 10;
        sum = sum + dig;
    }
    return sum;
}

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

int result = AdditionOfNumbers(number);
Console.Write(result);