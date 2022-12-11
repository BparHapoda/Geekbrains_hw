//Задача 5: * Найдите максимальное значение в матрице по каждой строке,
//получите сумму этих максимумов. Затем найдите минимальное значение 
//по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

int[][] array = new int[2][];
array[0] = new int[3] { 1, 2, 3 };
array[1] = new int[3] { 3, 4, 5 };


int sumMaxLines = 0;
for (int i = 0; i < array.Length; i++)
{
    sumMaxLines += max(array[i]);
}
int sumMinColumns = 0;
int[] temp = new int[array.Length];
int[] temp1 = new int[array[0].Length];
int minColumn = 0;
for (int j = 0; j < array[0].Length; j++)
{

    for (int k = 0; k < array.Length; k++)
    {
        temp[k] = array[k][j];
    }
    minColumn = min(temp);
    temp1[j] = minColumn;
}
sumMinColumns = sumArray(temp1);
Console.Write(sumMaxLines - sumMinColumns);



int min(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
    }
    return min;
}

int max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) { max = array[i]; }
    }
    return max;
}
int sumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;

}