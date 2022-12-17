//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] arr = getNewArray(5, 40);
Console.WriteLine("Исходный массив :");


printArray(arr);
Console.WriteLine("");
Console.WriteLine("Минимальная сумма элементов в строке  "+minSum(arr));


int minSum(int[,] arr)
{

    int sum;
    int minSum = 0;
    int index = 0;


    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        if (i == 0) { minSum = sum; index = 1; }
        else { if (sum < minSum) { minSum = sum; index = i + 1; } }

    }


    return index;
}


void printArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
}



int[,] getNewArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = (int)random.NextInt64(0, 10);

        }
    }
    return array;
}
