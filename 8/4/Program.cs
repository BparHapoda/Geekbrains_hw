//Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int n = 8;
int[,] arr = getSpiralArray(n);
printArray(arr);


int[,] getSpiralArray(int n)
{
    int[,] arr = new int[n, n];
    int xStart = 0;
    int yStart = 0;
    int count = 1;
    int maxNumber = n * n;
    arr[0, 0] = 1;
    int x = 0;
    int y = 0;
    while (count <= maxNumber)
    {
        x = xStart;
        y = yStart;
        while (inMatrix(x, y, arr) & count != maxNumber + 1)
        {
            arr[y, x] = count;
            x++;
            if (inMatrix(x, y, arr) && arr[y, x] != 0) { count++; break; }
            count++;
            if (count == maxNumber) { break; }

        }

        x--;
        y++;
        while (inMatrix(x, y, arr) & count != maxNumber + 1)
        {
            arr[y, x] = count;
            y++;
            if (inMatrix(x, y, arr) && arr[y, x] != 0) { count++; break; }
            count++;
            if (count == maxNumber) { break; }
        }
        y--;
        x--;
        while (inMatrix(x, y, arr) & count != maxNumber + 1)
        {
            arr[y, x] = count;
            x--;
            if (inMatrix(x, y, arr) && arr[y, x] != 0) { count++; break; }
            count++;
            if (count == maxNumber) { break; }
        }
        x++;
        y--;
        while (inMatrix(x, y, arr) & count != maxNumber + 1)
        {
            arr[y, x] = count;
            y--;
            if (inMatrix(x, y, arr) && arr[y, x] != 0) { count++; break; }
            count++;

        }
        xStart++;
        yStart++;

        //if(count==maxNumber){arr[y,x]=maxNumber;break;}
    }
    return arr;
}

Boolean inMatrix(int x, int y, int[,] matrix)
{
    return (x >= 0 & x < matrix.GetLength(0) & y >= 0 & y < matrix.GetLength(0));

}

void printArray(int[,] array)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write("\t" + arr[i, j] + " ");
        Console.WriteLine();
    }
}
