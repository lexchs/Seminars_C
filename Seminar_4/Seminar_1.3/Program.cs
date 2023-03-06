/*Задача 26: Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int FindNumbersDigits(int number)
{
    int size = 0;
    int num = number;
    while (num != 0)
    {
        num = num / 10;
        size++;
    }
    
    return size;
}

Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());

int res = FindNumbersDigits(a);
Console.Write(res);