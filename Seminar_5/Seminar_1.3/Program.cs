/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

void SearchNumber(int [] array, int number)
{
    int chto = 0;
    for(int i = 0;i < array.Length; i++)
    {
        if(array[i] == number)
        {
            chto++;
            Console.WriteLine("Yes");
        }
        
    }
if(chto==0)
        {
            Console.WriteLine("No");  
        }
}

int[] myarray = new int [] {6, 7, 19, 345, 3};

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
SearchNumber(myarray,number);
