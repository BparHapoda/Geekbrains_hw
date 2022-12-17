//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


int [,] arr= getNewArray(5,5);
Console.WriteLine("Исходный массив :");


printArray(arr);
Console.WriteLine("");
Console.WriteLine("Массив со строками по убыванию :");
printArray(minArray(arr));

int [,] minArray (int [,]arr ){
    int count;
    int min=0;
    int temp=0;
    
for(int i =0;i<arr.GetLength(0);i++){
    count=1;
    min=arr[i,0];
    while (count !=0){
        count=0;
    for(int j=0;j<arr.GetLength(1)-1;j++){
        if(arr[i,j+1]>arr[i,j]){temp=arr[i,j];arr[i,j]=arr[i,j+1];arr[i,j+1]=temp;count++;}
    }
    }
}

return arr;}


void printArray(int [,] array)
{

    for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
    }



int [,] getNewArray (int m,int n){
int[,] array = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] =(int) random.NextInt64(0,10);

    }
}
return array;}
