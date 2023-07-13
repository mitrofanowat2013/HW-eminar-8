//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9

int m = 2;

int n = 3;

FAkkerman(m,n);


void FAkkerman(int m, int n)
{
    Console.Write(AkkermanMN(m, n)); 
}

int AkkermanMN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanMN(m - 1, 1);
    }
    else
    {
        return (AkkermanMN(m - 1, AkkermanMN(m, n - 1)));
    }
}