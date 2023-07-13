// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 8;
int n = 1;
Perechislenie(number, n);

void Perechislenie(int z, int n)
{
    if (z < n)
    {
        return;
    }
    else
    {
       Perechislenie(z, n+1); 
        Console.Write(n + "  ");
        

    }    
}
