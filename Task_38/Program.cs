// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Console.WriteLine("Введите количество элементов: ");
int sumElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int minElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число диапазона: ");
int maxElement = Convert.ToInt32(Console.ReadLine());
double[] FillArrey(int num, int min, int max)
{
    double[] array = new iouble[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    { array[i] = rand.Next(min, max + 1); }
    return array;
}