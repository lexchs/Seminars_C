Console.Write("Введите первое число:");

int numa = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:");

int numb = int.Parse(Console.ReadLine());

int numasqr = numa * numa;

if(numasqr == numb)
{
    Console.WriteLine("Квадрат первого числа равен второму числу");
}
else
{
   Console.WriteLine("Квадрат первого числа не равен второму числу"); 
}