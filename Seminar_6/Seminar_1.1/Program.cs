// int[] arr = new int[] {1,2,3,4,5,6,7};
// for(int i = 0;i<(arr.Length/2);i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[(arr.Length-1)-i];
//     arr[(arr.Length-1)-i] = temp;
// }

// for(int i = 0;i<arr.Length;i++)
//     {
//         Console.Write(arr[i] + " ");
//     }


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


// Задача 40: Напишите программу, которая принимает на 
// вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.

// void ThisIsTriangle(int a,int b,int c)
// {
//     if(a+b>c & a+c>b & c+b>a)
//     {
//         Console.WriteLine("This is triangle");
//     }
//     else Console.WriteLine("This isn't triangle");
// }

// Console.Write("Enter the length of side A: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Enter the length of side B: ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Enter the length of side C: ");
// int c = int.Parse(Console.ReadLine());

// ThisIsTriangle(a,b,c);

// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// string DecimalToBinary(int num)
// {
//     int tempnum = num;
//     string result = "";
//     while(tempnum>0)
//     {
//         result = Convert.ToString(tempnum % 2) + result;
//         tempnum /= 2;
//     }
//     return result;
// }

// Console.Write("Enter the number: ");
// int a = int.Parse(Console.ReadLine());

// string res = DecimalToBinary(a);
// Console.WriteLine(res);

// Задача 44: Не используя рекурсию, выведите первые 
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void ShowDoubleArray (double[] array)
// {  
//     //Вывод с помощью foreach
//     foreach (var elem in array) 
//     {
//         Console.Write("{0} ", elem);
//     }

//     Console.WriteLine();
// }

// void printFibonachi(int num)
// {
//     double[] array = new double[num];
//     array[0] = 0;
//     array[1] = 1;

//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i-1]+array[i-2];
//     }
 
//     ShowDoubleArray (array);

// }

//  Console.Write("Введите десятичное число: ");
// int num = int.Parse(Console.ReadLine());

// printFibonachi(num);



// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] tarr = CreateAnIntArrayRandom(1,10,10);

OutputAnIntArray(tarr);                       