//Задача 1: Задайте значения M и N. Напишите программу, которая выведет
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int m = inputNumber("m");
int n = inputNumber("n");

Console.Write("\nM = " + m + "; N = " + n + " - > ");
numbers(m, n);

int inputNumber(String str)
{
    Console.WriteLine("Введите число " + str + " : ");
    str = Console.ReadLine();
    int n = Int32.Parse(str);
    return n;
}

void numbers(int m, int n)
{
    if (m == n)
    {

        return;
    }
    if (m % 2 == 0)
    {
        Console.Write(m + " ");
    }
    m++;
    numbers(m, n);

}
