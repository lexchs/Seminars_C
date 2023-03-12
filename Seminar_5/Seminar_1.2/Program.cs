/*Задача 32: Напишите программу замена элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/

void GetNegarray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int[] myarray = new int[] {-4, -8, 8, 2};

GetNegarray(myarray);

for(int i = 0; i<myarray.Length;i++)
{
    Console.Write(myarray[i]+" " );
}