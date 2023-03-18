
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int GetLenght()
// {
//     Console.Write("How many numbers will you enter?: ");
//     int arrlenght = int.Parse(Console.ReadLine());
//     return arrlenght;
// }

// int[] CreateAnArray(int size)
// {
//     int [] array = new int [size];
//     for(int i = 0; i<array.Length;i++)
//     {
//         Console.Write($"Enter the number number {i+1}:" );
//         int num = int.Parse(Console.ReadLine());
//         array [i] = num;
//         Console.Clear();
//     }
//     return array;
// }

// void OutputAnIntArray(int[]array)
// {
//     for(int i = 0;i<array.Length;i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// void OutputPositiveCountOfNum(int[]array)
// {
//     Console.WriteLine();
//     int count = 0;
//     for(int i = 0;i<array.Length;i++)
//     {
//         if (array[i]>0) count++;
//     }
//     Console.Write($"You have entered {count} positive numbers.");
// }

// int size = GetLenght();
// int[]myarr=CreateAnArray(size);
// OutputAnIntArray(myarr);
// OutputPositiveCountOfNum(myarr);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*

y = k1 * x + b1,
k1*x = y-b1

y = k2 * ((y-b1)/2) + b2


*/

// Console.WriteLine("Поиск точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
// Console.Write("Enter b1: ");
// double b1 = double.Parse(Console.ReadLine());
// Console.Write("Enter k1: ");
// double k1 = double.Parse(Console.ReadLine());
// Console.Write("Enter b2: ");
// double b2 = double.Parse(Console.ReadLine());
// Console.Write("Enter k2: ");
// double k2 = double.Parse(Console.ReadLine());

// void FindOutDot(double k1,double k2,double b1,double b2)
// {
//     double x = (b2-b1)/(k1-k2);
//     double y = k1 * x + b1;
//     Console.WriteLine($"({x},{y})");
// }
// FindOutDot(k1,k2,b1,b2);

