//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 1 | 3 4
//3 2 1 | 3 3
//_ _ _ | 1 1
//Результирующая матрица будет:
//19 21
//16 19

int[,] matrix1 = getNewArray(3, 4);
Console.WriteLine("Матрица 1 :");
printArray(matrix1);

int[,] matrix2 = getNewArray(4, 3);
Console.WriteLine("Матрица 2 :");
printArray(matrix2);
if (!wrongMatrix(matrix1, matrix2))
{
    Console.WriteLine("Умножение матриц  :");
    printArray(MultMatrix(matrix1, matrix2));
}
else { Console.WriteLine("Умножение невозможно ,тк количество строк первой матрицы не равно кол-ву столбцов второй"); }



Boolean wrongMatrix(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(0) != matrix2.GetLength(1);
}


int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int sum = 0;

    int[,] resMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {

            sum = 0;

            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                sum += matrix1[i, j] * matrix2[j, k];
            }
            resMatrix[i, k] = sum;
        }
    }






    return resMatrix;
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

