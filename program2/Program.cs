// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Задайте количество сторок m :");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов n :");
int sizeN = Convert.ToInt32(Console.ReadLine());

if (sizeM == sizeN)
{
    int[,] array = new int[sizeM, sizeN];
    ArrayRandomNumbers(array);// Заполнение массива числами.
    PrintArray(array);//Вывод массива на экран.
    SmallestSumOfNumbers(array, sizeM, sizeN);//Нахождение строки с наименьшей суммой.
}
else
{
Console.WriteLine("Стороны массива не равны.");
}

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Созданный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void SmallestSumOfNumbers(int[,] array, int sizeM, int sizeN)
{
   int minRowSum = int.MaxValue, indexMinRow = 0;
 
    for (int i = 0; i < sizeM; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < sizeN; j++)
        rowSum += array[i, j];
        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }
     }
 
    Console.WriteLine("Строка с минимальной суммой элементов " +(indexMinRow+1)+ ", сумма элементов = "+minRowSum+".");
}