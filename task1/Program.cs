// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNum(int M, int N)
{
    if (M <= N)
    {
        if(M%2 == 0)
        {
        System.Console.Write($"{M}\t");
        PrintEvenNum(M + 2, N);
        }
        else
        {
        PrintEvenNum(M + 1, N);
        }
    }
}

int M = ReadInt("Введите первое число");
int N = ReadInt("Введите второе число");
PrintEvenNum(M, N);


