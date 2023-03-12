int GetSumPosit(int[] array)
{
    int sump = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array [i] > 0)
        {
            sump = sump + array[i];
        }
    }
    return sump;
}

int GetSumNegative(int[] array)
{
    int sumn = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sumn = sumn + array[i];
        }
    }
    return sumn;
}

void PrintArrayToConsole(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine();
}

/////////////////////////////////////////////////

 int [] myarray = new int [12];
 for(int i = 0; i < myarray.Length; i++)
 {
     myarray [i] = new Random().Next(-9,10);
 }

PrintArrayToConsole(myarray);

int sumPosElem = GetSumPosit(myarray);
int sumNegElem = GetSumNegative(myarray);

Console.WriteLine("Сумма позитивных элементов: " + sumPosElem);
Console.WriteLine("Сумма отрицательных элементов: " + sumNegElem);