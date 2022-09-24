// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Задайте количество сторок первой матрицы:");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов первой матрицы (строк второй):");
int sizeN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов второй матрицы:");
int sizeB = Convert.ToInt32(Console.ReadLine());

int[,] martrixOne = new int[sizeM, sizeN];
ArrayRandomNumbers(martrixOne);// Заполнение матрицы числами.
Console.WriteLine("Первая матрица:");
PrintArray(martrixOne);//Вывод матрицы на экран.

int[,] martrixTwo = new int[sizeN, sizeB];
ArrayRandomNumbers(martrixTwo);// Заполнение матрицы числами.
Console.WriteLine("Вторая матрица:");
PrintArray(martrixTwo);//Вывод матрицы на экран.

int[,] matrixResult = new int[sizeM, sizeB]; 
FinishedMatrix(martrixOne, martrixTwo, matrixResult);//Произведение 2 матриц.
Console.WriteLine("Произведение 2 матриц:");
PrintArray(matrixResult);//Вывод матрицы на экран.


void FinishedMatrix(int[,] martrixOne, int[,] martrixTwo, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < martrixOne.GetLength(1); k++)
            {
                sum += martrixOne[i,k] * martrixTwo[k,j];
            }
            matrixResult[i,j] = sum;
        }
    }
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