//Задача 2. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Ряд > 1
//Колонка > 7
//1, 7 -> такого числа в массиве нет
int[,] numbers =  {
                       {1,4,7,2},
                       {5,9,2,3},
                       {8,4,2,4},
                       };

int rows = numbers.GetUpperBound(0) + 1;
int columns = numbers.Length / rows;



for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{numbers[i, j]} \t");
    }
    Console.WriteLine();
}

while (true)
{
    Console.WriteLine("Введите координаты элемента через , : (для выхода q");
    string str = Console.ReadLine();
    if (str.Equals("q")) { break; }
    string[] str1 = new string[2];
    str1 = str.Split(",");
    int[] a = new int[2];
    a[0] = Convert.ToInt32(str1[0]);
    a[1] = Convert.ToInt32(str1[1]);
    if ((a[0] < 0 || a[0] > columns - 1) || (a[1] < 0 || a[1] > rows - 1)) { Console.WriteLine("Мимо "); }
    else
    {
        Console.WriteLine(numbers[a[0], a[1]]);
    }
}