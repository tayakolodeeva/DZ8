// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите значение m:");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n:");
int sizeN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b:");
int sizeB = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[sizeM, sizeN, sizeB];
ArrayRandomNumbers(array);// Заполнение массива числами.
Console.WriteLine("Элементы массива с индексами:");
PrintArray(array);//Вывод массива на экран.

void ArrayRandomNumbers(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j ++)
    {
      Console.Write($"{i}, {j}, ");
      for (int k = 0; k < array.GetLength(2); k ++)
      {
        Console.Write( $"({k})=>{array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}