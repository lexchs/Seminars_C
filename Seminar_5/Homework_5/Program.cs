int[] CreateAnIntArrayRandom(int firstDig, int secondDig,int size)
{
    int [] array = new int [size];
    for(int i = 0; i<array.Length;i++)
    {
        array [i] = new Random().Next(firstDig,secondDig);
    }
    return array;
}

double [] CreateAnDoubleArrayRandom(int firstDig,int secondDig,int size)
{
    double [] array = new double[size];
    for(int i=0;i<array.Length;i++)
    {
        array[i] = new Random().Next(firstDig,secondDig);
    }
    return array;
}

void OutputAnIntArray(int[]array)
{
    for(int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
}

void OutputAnDoubleArray(double[]array)
{
    for(int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ShowNumberOfEvennumbers(int[]array)
{
    int count = 0;
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int SumOfOddPositions(int[]array)
{
    int sum = 0;
    for(int i = 0;i<array.Length;i++)
    {
        if(i % 2 !=0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

double DiffMinMaxAnDoubleArray(double[]array)
{
    Array.Sort(array);
    double diff = 0;
    diff = array[array.Length-1] - array[0];
    return diff;
}

Console.Write("Enter homework number(34,36,38): ");
int worknum = int.Parse(Console.ReadLine());
switch (worknum)
{
    case 34:
        /*Задача 34: Задайте массив заполненный случайными 
        положительными трёхзначными числами. 
        Напишите программу, которая покажет количество 
        чётных чисел в массиве.
        [345, 897, 568, 234] -> 2
        */

        int[] myarr = CreateAnIntArrayRandom(100,999,10);
        OutputAnIntArray(myarr);
        Console.WriteLine();
        int res = ShowNumberOfEvennumbers(myarr);
        Console.WriteLine(res);

        break;
    case 36:
        /*Задача 36: Задайте одномерный массив, заполненный 
        случайными числами. Найдите сумму элементов, 
        стоящих на нечётных позициях.
        [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0
        */

        int[] myarr2 = CreateAnIntArrayRandom(-10,10,4);
        OutputAnIntArray(myarr2);
        Console.WriteLine();
        int res2 = SumOfOddPositions(myarr2);
        Console.WriteLine(res2);
        break;
    case 38:
        /*Задача 38: Задайте массив вещественных чисел. Найдите 
        разницу между максимальным и минимальным элементов массива.
        [3 7 22 2 78] -> 76
        */

        double [] myarr3 = CreateAnDoubleArrayRandom(1,10,4);
        OutputAnDoubleArray(myarr3);
        Console.WriteLine();
        double res3 = DiffMinMaxAnDoubleArray(myarr3);
        Console.WriteLine(res3);
        break;
    default:
        Console.WriteLine("There is no such homework");
        break;
}
