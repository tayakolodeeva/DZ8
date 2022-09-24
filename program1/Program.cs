// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Задайте количество сторок m :");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов n :");
int sizeN = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[sizeM, sizeN];

ArrayRandomNumbers(array);// Заполнение массива числами.
PrintArray(array);//Вывод массива на экран.
ArrangeTheArray(array);//Упорядочить по убыванию элементы каждой строки.
PrintAnOrderedArray(array);//Вывести упорядоченный массив.

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

void ArrangeTheArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

void PrintAnOrderedArray(int[,] array)
{
    Console.WriteLine("Cозданный массив с упорядоченными по убыванию элементами строки:");
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

