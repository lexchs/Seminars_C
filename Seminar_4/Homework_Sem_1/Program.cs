/*Задача 25: Напишите метод, который принимает на 
вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double Exponentiation(int a, int b)
{
    double res = Math.Pow(a,b);
    return res;
}

Console.Write("Enter number A: ");
int numa = int.Parse(Console.ReadLine());

Console.Write("Enter number B: ");
int numb = int.Parse(Console.ReadLine());

double result = Exponentiation(numa, numb);
Console.Write(result);