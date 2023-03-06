/*Задача 30: Напишите программу, которая выводит 
массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int [] array = new int [8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}

void PrintArray(int [] num)
{
    int count = 0;
    while(count < num.Length)
    {
        if(count == num.Length - 1)
        {
            Console.Write($"{num[count]}");
            break;
        }
        Console.Write($"{num[count]}, ");
        count++;
    }                             
}
PrintArray(array);