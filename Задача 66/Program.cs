// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int i = 4;

int j = 8;

SumN(i, j);


void SumN(int i, int j)
{
    Console.Write(SumIJ(i - 1, j));
}


int SumIJ(int i, int j)
{
    int itog = i;
    if (i == j)
        return 0;
    else
    {
        i++;
        itog = i + SumIJ(i, j);
        return itog;
       
        
    }
}
      