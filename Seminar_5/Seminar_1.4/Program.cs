/*Задача 35: Задайте одномерный массив из 123 
случайных чисел. Найдите количество элементов
 массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int [] myarr = new int [123];
for(int i = 0;i<myarr.Length;i++)
{
    myarr [i] = new Random().Next(-100,100);
}

int HowManyNumbers(int[] myarr)
{
    int count = 0;
    for(int i = 0;i<myarr.Length;i++)
    {
        if(myarr[i]>10 & myarr[i]<99)
        {
            count++;
        }
    }
    return count;
    
}
int kolvo = HowManyNumbers(myarr);
Console.WriteLine(kolvo);