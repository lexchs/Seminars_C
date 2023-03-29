// Задайте значение N. Напишите программу,
// которая выведет все четные натуральные числа в промежутке от m до N . 
// Выполнить с помощью рекурсии.
// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

(int, int) CheckInput(int M, int N)
{
    M = Math.Abs(M);
    N = Math.Abs(N);

    if (N < M)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    return (M, N);
}

void GetEvenNumbers(int M, int N)
{

    if (M == N)
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}");
        }
    }
    else
    {
        if ((M % 2) == 0)
        {
            Console.Write($"{M}, ");
        }
        M++;
        GetEvenNumbers(M, N);
    }
}

int GetSumMToN(int m, int n)
{
    int sum = 0;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        sum = m + GetSumMToN(m,n);
        return sum;
    }
}

int GetAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else
    {
        if ((m > 0) && (n == 0))
        {
            return GetAkkermanFunction(m - 1,1);
        }
        else
        {
            return GetAkkermanFunction(m-1, GetAkkermanFunction(m,n-1));
        }
    }
}

// int M = Prompt("Введите число M: ");
// int N = Prompt("Введите число N: ");
// (M, N) = CheckInput(M, N);
// Console.WriteLine($"Все четные числа из промежутка от {M} до {N} => ");
// GetEvenNumbers(M, N);

// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M2 = Prompt("Введите число M: ");
// int N2 = Prompt("Введите число N: ");
// (M2, N2) = CheckInput(M2, N2);
// Console.WriteLine($"Сумма чисел от {M2} до {N2} = {GetSumMToN((M2-1),N2)}");

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int M3 = Prompt("Введите число M: ");
// int N3 = Prompt("Введите число N: ");
// (M3, N3) = CheckInput(M3, N3);
// Console.WriteLine($"Результат вычисления функции Аккермана для чисел {M3} и {N3} = {GetAkkermanFunction(M3,N3)}");