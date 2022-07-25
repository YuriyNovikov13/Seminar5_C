// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Введите количество элементов массива: ");
int sumElement = Convert.ToInt32(Console.ReadLine());
int minElement = -100;
int maxElement = 101;
int[] FillArrey(int num, int min, int max)
{
    int[] array = new int[num];
    Random rand = new Random();
    for (int i = 0; i < num; i++)
    { array[i] = rand.Next(min, max + 1); }
    return array;
}
int SumPosElement(int[] array)
{
    int sumPosElement = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
       sumPosElement = sumPosElement + array[i];
    }
    return sumPosElement;
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
int result = SumPosElement(arr);
Console.WriteLine($"Сумма элементов на нечётных позициях = {result}");