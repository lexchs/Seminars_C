int[,] CreateArray(int countRows, int countColumns)
{
    int[,] resultArray = new int[countRows, countColumns];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(0, 10);
        }
    }
    return resultArray;
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

int[,] MoveFirstLastRows(int[,] array)
{
    int firstRow = 0;
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Swap(array, firstRow, lastRow, i);
    }

    return array;
}

void Swap(int[,] array, int i1, int i2, int j)
{

    (array[i1, j], array[i2, j]) = (array[i2, j], array[i1, j]);
}

bool ValidateMatrix(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        return true;
    }
    return false;
}

int[,] TransportArray(int[,] array)
{
    if (ValidateMatrix(array))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
            }
        }
        return array;
    }
    else
    {
        throw new Exception("Невозможно");
    }
}

int[] GetFrequencyNumbers(int[,] array)
{
    int[] resArray = new int[10];
    foreach (int item in array)
    {
        resArray[item]++;
    }

    return resArray;
}

int[,] SortArrayRows(int[,] array)
{
    for (int k = 0; k <= (array.GetLength(1)-1); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int max = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = max;
                }
            }
        }
    }

    return array;
}

int MinSumElemRows(int[,] array)
{
    int sum = 0;
    int tempSum = 0;
    int minrow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            if (i == 0)
            {
                tempSum = sum;
                minrow = i + 1;                
            }
        }
        
        if (sum < tempSum)
        {
            tempSum = sum;
            minrow = i + 1;
        }
        sum = 0;
    }

    return minrow;
}

int[,] MultiplicationMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] newArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

    if ((firstArray.GetLength(0) * firstArray.GetLength(1)) == (secondArray.GetLength(0) * secondArray.GetLength(1)))
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    newArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine();
        System.Console.Write("Данные матрицы невозможно перемножить!");
    }
    return newArray;
}

int[,,] GenerTripleArray(int min, int max)
{
    int[,,] array = new int[2, 2, 2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }

    return array;
}

void PrintTripleArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i, j, k)}\t");
            }
        }
    }
}

int[,] GenerArraySpiral(int row, int column)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (j + i) + 1;

        }
    }

    for (int i = array.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = array.GetLength(1) - 1; j > 0; j--)
        {
            array[i, j - 1] = 4 * row - (i + j) - 2;
        }
    }

    for (int i = 1; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < array.GetLength(1) - 1; j++)
        {
            array[i, j] = 3 * row + j;
        }
    }

     for (int i = array.GetLength(0) - 2; i >= 2; i--)
    {
        for (int j = array.GetLength(1) - 1; j > 1; j--)
        {
            array[i, j - 1] = 5 * row - i - j;
        }
    }
 

    return array;
}

void PrintArraySpiral(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        while (count != 3)
        {
            System.Console.WriteLine();
            count++;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
}


// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// int [,] myarr = CreateArray(4,4);
// PrintArray(myarr);
// SortArrayRows(myarr);
// PrintArray(myarr);
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// int [,] myarr = CreateArray(4,4);
// PrintArray(myarr);
// int res = MinSumElemRows(myarr);
// Console.WriteLine(res);

// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int [,] myarr = CreateArray(2,3);
// PrintArray(myarr);
// int [,] myarr2 = CreateArray(3,2);
// PrintArray(myarr2);
// int[,] newMyArr = MultiplicationMatrix(myarr, myarr2);
// PrintArray(newMyArr);

// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив. 

// int[,,] tripleArray = GenerTripleArray(1, 10);
// PrintTripleArray(tripleArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] spiralArray = GenerArraySpiral(4, 4);
PrintArraySpiral(spiralArray);