   
int[,] FillTableArray(int roll,int columns)
{
    int[,] array = new int [roll,columns];
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

int[,] FillTableArrayTask48(int roll,int columns)
{
    int[,] array = new int [roll,columns];
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

int[,] FillTableArrayTask49(int[,]array)
{
    for (int i = 1; i<array.GetLength(0);i++)
    {
        for (int j = 1; j<array.GetLength(1);j++)
        {
            if(i%2==0 & j%2==0) array[i,j] = array[i,j] * array[i,j];
        }
    }
    return array;
}

void PrintTableArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i, j]} ");;
        }
    Console.WriteLine();
    }
}

int PrintSumTask50(int[,]array)
{
    int sum = 0;
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            if(i==j)
            {
                sum += array[i,j];
            }
        }
    }
    return sum;
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// Console.Clear();
// Console.WriteLine("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArray(r,c);
// PrintTableArray(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
// массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// Console.Clear();
// Console.WriteLine("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArrayTask48(r,c);
// PrintTableArray(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Clear();
// Console.WriteLine("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArray(r,c);
// PrintTableArray(myarr);
// Console.WriteLine();
// FillTableArrayTask49(myarr);
// PrintTableArray(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

// Console.Clear();
// Console.WriteLine("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.WriteLine("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArray(r,c);
// PrintTableArray(myarr);
// Console.WriteLine();
// int res = PrintSumTask50(myarr);
// Console.Write(res);


