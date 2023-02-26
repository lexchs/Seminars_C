//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Привет, введите первое число: ");
int numa = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numb = int.Parse(Console.ReadLine());

int max = numa;

if(numa>numb)
{
   Console.WriteLine($"Число {numa} больше числа {numb}."); 
}
else
{
    Console.WriteLine($"Число {numb} больше числа {numa}.");
}