//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Дано : y = k1 * x + b1 и y = k2 * x + b2" + "\n");
double b1 = getNumber("b1");
double k1 = getNumber("k1");
double b2 = getNumber("b2");
double k2 = getNumber("k2");
if (b1 == b2) { Console.Write("Прямые не пересекаются"); }
else
{
    double[] result = calc(b1, k1, b2, k2);
    Console.Write("b1= {0}, k1= {1}, b2= {2}, k2= {3}", b1, k1, b2, k2);
    Console.Write(" -> ");
    Console.Write("(" + result[0] + "; " + result[1] + ")");
}

double[] calc(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    array[0] = x;
    array[1] = y;
    return array;

}


int getNumber(string str)
{
    Console.Write("Введите " + str + "\n");
    string str1 = Console.ReadLine();
    return Convert.ToInt32(str1);


}