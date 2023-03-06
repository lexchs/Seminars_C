/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
void FindPalindrome(int n)
{
    if(n<=99999 & n>9999)
    {
        int firstdigit = n /10000;
        int seconddigit = n / 1000 - firstdigit * 10;
        int fivedigit = n % 10;
        int fourdigit = (n % 100 - fivedigit) / 10;
        if(firstdigit == fivedigit & seconddigit == fourdigit)
        {
            Console.Write($"Number {n} palindrome");
        }
        else
        {
            Console.Write($"Number {n} is not a palindrome");
        }
    }
    else
    {
        Console.Write("It's not a five digit number");
    }
}

Console.Write("Enter a five digit number: ");
int number = int.Parse(Console.ReadLine());
FindPalindrome(number);
