//Задача 3: Напишите программу вычисления функции Аккермана с
// помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int m = inputNumber("m");
int n = inputNumber("n");
Console.WriteLine("m = " + m + ", n = " + n + " -> A(m,n) = " + ackerman(m, n));


int inputNumber(String str)
{
    Console.WriteLine("Введите число " + str + " : ");
    str = Console.ReadLine();
    int n = Int32.Parse(str);
    return n;
}

int ackerman(int m, int n)
{
    if (m == 0) { return n + 1; }
    if (m > 0 && n == 0)
    {
        return ackerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return ackerman(m - 1, ackerman(m, n - 1));
    }
    return 0;
}