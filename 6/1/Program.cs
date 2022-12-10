//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы массива через пробел : ");
string str = Console.ReadLine();
if (str != null)
{
    int[] array = Array.ConvertAll(str.Split(" "), int.Parse);
    printArray(array);
    Console.Write(" -> ");
    Console.Write(countNumbersArray(array));
}



int countNumbersArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { count++; }
    }
    return count;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else { Console.Write(array[i]); }
    }
}