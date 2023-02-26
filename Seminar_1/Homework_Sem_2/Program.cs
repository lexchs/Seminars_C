//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Напиши 3 числа через пробел: ");
string[] arr= Console.ReadLine().Split();
 
int numa = int.Parse(arr[0]);
int numb = int.Parse(arr[1]);
int numc = int.Parse(arr[2]);

int max = numa;

if (numa > numb & numa > numc)
{
    max = numa;
    Console.WriteLine($"{numa} - самое большое число");
}
 else
 {
    if(numc>numb)
    {
        max = numc;
        Console.WriteLine($"{numc} - самое большое число");
    }
    else
    {
       max = numb;
        Console.WriteLine($"{numb} - самое большое число"); 
    }
 }
