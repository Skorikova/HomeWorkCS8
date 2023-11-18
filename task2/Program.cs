//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.


int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers (int M, int N)
{
    if(N < M)
    {
        return 0;
    }
   return SumNumbers(M, N-1) + N;
   System.Console.Write($"{M}\t");
   
    
}
int M = ReadInt("Введите первое число");
int N = ReadInt("Введите второе число");
Console.WriteLine(SumNumbers(M,N));






