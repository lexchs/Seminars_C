int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] FillTableDoubleArray(int roll,int columns)
{
    double[,] array = new double [roll,columns];
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            array[i,j] = Math.Round(new Random().Next(1, 101)*0.1,1);
        }
    }
    return array;
}

void PrintTableDoubleArray(double[,] array)
{
    for (int i = 0; i<array.GetLength(0);i++)
    {
        for (int j = 0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
    Console.WriteLine();
    }
}

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

void GetNumTableArray(int[,] array)
{
    int r = Prompt("Enter roll: ");
    int c = Prompt("Enter column: ");
    if(r<array.GetLength(0) && c<array.GetLength(1)) Console.WriteLine(array[r,c]);
    else Console.WriteLine("Error");

}

void ShowAvrgColumns(int [,] array)
{
    double avrg = 0;
    double sum = 0;
    for (int j = 0; j<array.GetLength(1);j++)
    {
        for (int i = 0; i<array.GetLength(0);i++)
        {
            sum = array[i,j] + sum;
        }
        avrg = sum/array.GetLength(0);
        Console.Write($"{Math.Round(avrg,1)}; ");
        sum = 0;
    }


}

void OutputAnIntArray(int[]array)
{
    for(int i = 0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CreateAnIntArrayRandom(int firstDig, int secondDig,int size)
{
    int [] array = new int [size];
    for(int i = 0; i<array.Length;i++)
    {
        array [i] = new Random().Next(firstDig,secondDig);
    }
    return array;
}

int[] TwoSum(int[] nums, int target) 
{
    for(int i = 0;i<nums.Length;i++)
    {
        for(int j = i +1;j<nums.Length; j++)
        {
            if(nums[j] == target-nums[i])
            {
                return new int[] {i,j}; 
            }
        }
    }
    return null;
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();
// Console.Write("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.Write("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// double[,]myarr = FillTableDoubleArray(r,c);
// PrintTableDoubleArray(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// Console.Write("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.Write("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArray(r,c);
// PrintTableArray(myarr);
// GetNumTableArray(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// Console.Write("Кол-во строк массива: ");
// int r = int.Parse(Console.ReadLine());
// Console.Write("Кол-во столбцов массива: ");
// int c = int.Parse(Console.ReadLine());
// int[,]myarr = FillTableArray(r,c);
// PrintTableArray(myarr);
// ShowAvrgColumns(myarr);


//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// 1. Two Sum
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// int[]myarr = CreateAnIntArrayRandom(1,10,10);
// OutputAnIntArray(myarr);
// Console.WriteLine();
// int target = Prompt("Enter target: ");
// int[] narr = TwoSum(myarr,target);
// Console.WriteLine();
// OutputAnIntArray(narr);