//Напишите программу, которая по заданному 
//номеру четверти, показывает диапазон 
//возможных координат 
//точек в этой четверти (x и y).

void FindQuarter(int num)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("x>0, y>0");
            break;
        case 2:
            Console.WriteLine("x<0, y<0");
            break;
        case 3:
            Console.WriteLine("x<0, y>0");
            break;
        case 4:
            Console.WriteLine("x>0, y<0");
            break;
        default:
            Console.WriteLine("No such quarter");
            break;
    }
}
Console.Write("Enter a quarter: ");
int a = int.Parse(Console.ReadLine());
FindQuarter(a);