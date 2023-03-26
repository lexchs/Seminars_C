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

void PrintArrayJ(int[] array)
{
    Console.WriteLine($"[{String.Join(",", array)}]");
}

(int row,int column) GetIndexesOfMin(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[minRow,minColumn]>array[i,j])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow,minColumn);
}

int [,] DeleteByIndexes (int [,] array, int row,int column)
{
    int [,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i == row)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == column)
            {
                continue;
            }
            newArray[k,l] = array[i,j];
            l++;
        }
        k++;
        l=0;
    }
    return newArray;

}

// int[,] myarr = CreateArray(3,4);
// PrintArray(myarr);
// PrintArray(MoveFirstLastRows(myarr));


////////////////////////////////////////////////////////////////////////////////////////

// int[,] myarr = CreateArray(5, 3);
// PrintArray(myarr);
// try
// {
//     TransportArray(myarr);
//     PrintArray(myarr);
// }
// catch (Exception e)
// {
//     Console.WriteLine(e.Message);
// }


////////////////////////////////////////////////////////////////////////////////////////////

// int[,] myarr = CreateArray(5, 3);
// PrintArray(myarr);
// int[] arrayres = GetFrequencyNumbers(myarr);
// PrintArrayJ(arrayres);


////////////////////////////////////////////////////////////////////////////
int[,] myarr = CreateArray(4, 4);
(int row,int column) = GetIndexesOfMin(myarr) ;
PrintArray(myarr);
PrintArray(DeleteByIndexes(myarr,row,column));