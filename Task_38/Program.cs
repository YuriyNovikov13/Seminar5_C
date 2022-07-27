// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// Console.WriteLine("Введите количество элементов: ");
// int sumElement = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число диапазона: ");
// double minElement = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число диапазона: ");
// double maxElement = Convert.ToInt32(Console.ReadLine());
// double[] FillArrey(int num, double min, double max)
// {
Console.WriteLine("Введите количество элементов массива: ");
int sumElement = Convert.ToInt32(Console.ReadLine());

double[] FillArrey(int num)
{
    double[] array = new double[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    { array[i] = Math.Round(rand.NextDouble()*10, 1); }
    return array;
}
double GetMaxMinElem(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return max - min;
}



void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i] + "]");
    }
}
double[] arr = FillArrey(sumElement);
PrintArray(arr);
double result = GetMaxMinElem(arr);
Console.WriteLine ($"разница между макимальным и минимальным элементом массива = {result}");
