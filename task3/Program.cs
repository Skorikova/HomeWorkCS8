// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string mes)
{
    Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AkkermanFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if(n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1,AkkermanFunction(m, n - 1));
    }
}
int m = ReadInt("Введите первое число");
int n = ReadInt("Введите второе число");
Console.WriteLine(AkkermanFunction(m,n));