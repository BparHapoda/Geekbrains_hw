using System;
using System.Collections;

//Задача 3. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] array = {
                {1,4,7,2},
                {5,9,2,3},
                {8,4,2,4}
                };
int rows = array.GetUpperBound(0) + 1;
int columns = array.Length / rows;

Console.Write("Среднее арифметическое каждого столбца: ");
int sum;

for (int i = 0; i < columns; i++)
{
    sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum += array[j, i];

    }
    Console.Write(" ");
    Console.Write(Math.Round(Convert.ToDouble(sum) / Convert.ToDouble(rows), 2));
}
