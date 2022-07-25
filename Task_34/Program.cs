// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов массива: ");
int sumElement= Convert.ToInt32(Console.ReadLine());
int minElement = 100;
int maxElement = 999;
int[] FillArrey(int num, int min, int max)
{
    int[] array = new int[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    { array[i] = rand.Next(min, max + 1); }
    return array;
}
int SumEven(int[] array)
{
    int sumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sumEven++;
        }
    }
return sumEven;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");
    }
}
int[] arr = FillArrey(sumElement, minElement, maxElement);
PrintArray(arr);
int result = SumEven(arr);
Console.WriteLine ($"колличество чётных чисел в массиве = {result}");