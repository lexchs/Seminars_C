/*Задача 29: Напишите программу, которая 
задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int [] randmas = new int [8];
for(int i = 0;i < randmas.Length; i++)
{
    randmas[i]= new Random().Next(-100,100);
}

void PrintArray(int [] arr)
{
    int count = 0;
    while(count < arr.Length)
    {
        if(count == arr.Length - 1)
        {
            Console.Write($"{arr[count]}");
            break;
        }
        Console.Write($"{arr[count]}, ");
        count++;
    }
}

PrintArray(randmas);