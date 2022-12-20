//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m = inputNumber("m");
int n = inputNumber("n");
int a = numbers(m, n, 0);
Console.WriteLine("M = " + m + "; N = " + n + " - > " + a);


int inputNumber(String str)
{
    Console.WriteLine("Введите число " + str + " : ");
    str = Console.ReadLine();
    int n = Int32.Parse(str);
    return n;
}

int numbers(int m, int n, int sum)
{

    if (m > n)
    {
        return sum;
    }


    sum += m;
    m++;
    return numbers(m, n, sum);
}