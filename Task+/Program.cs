// Напишите программу, которая реализует обход введенного двумерного массива, 
// начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9


int[,] GetRandomArray(int size, int height, int minValue, int maxValue)
{
    int[,] matr = new int[size, height];
    for (int i = 0; i < size ; i++)
    {
        for (int j = 0; j < height; j++)
        {
            matr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matr;
}

int[] CopyOneDimensionArray(int[,] array)
{
    int[] newArray=new int[array.Length];
    int newArrayCount = 0;
    int quantityOfValues = array.Length;
    int quantityOfRows = array.GetLength(0);
    int quantityOfColumns = array.GetLength(1);

    for (int i = 0; i < quantityOfValues; i++)
    {
        if (newArrayCount < array.Length)
        {
            for (int rowStepRight = 0 + i; rowStepRight < quantityOfColumns - i; rowStepRight++)
            {
                int positionForStepRight = quantityOfRows - 1 - i;
                newArray[newArrayCount] = array[positionForStepRight, rowStepRight];
                newArrayCount++;
            }
        }

        if (newArrayCount < array.Length)
        {
            for (int columnStepUp = quantityOfRows - 2 - i; 0 + i <= columnStepUp; columnStepUp--)
            {
                int positionForStepUp = quantityOfColumns - 1 - i;
                newArray[newArrayCount] = array[columnStepUp, positionForStepUp];
                newArrayCount++;
            }
        }

        if (newArrayCount < array.Length)
        {
            for (int rowStepLeft = quantityOfColumns - 2 - i; 0 + i <= rowStepLeft; rowStepLeft--)
            {
                int positionStepLeft = 0 + i;
                newArray[newArrayCount] = array[positionStepLeft, rowStepLeft];
                newArrayCount++;
            }
        }

        if (newArrayCount < array.Length)
        {
            for (int columnStepDown = 1 + i; columnStepDown < quantityOfRows - 1 - i; columnStepDown++)
            {
                int positionForStepDown = 0 + i;
                newArray[newArrayCount] = array[columnStepDown, positionForStepDown];
                newArrayCount++;
            }
        }
    }
    return newArray;
}

void PrintMatrixArray(int[,] matr)
{
    for (int i = 0; i< matr.GetLength(0); i++ )
    {
        for (int j = 0; j<matr.GetLength(1); j++ ) 
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void main()
{
    Console.Clear();
    int[,] newArray = GetRandomArray(6, 6, 10, 99);
    Console.WriteLine("Многомерный массив, напоненный случайными числами:");
    PrintMatrixArray(newArray);
    Console.WriteLine();
    Console.WriteLine("Одномерный массив, полученный из преобразования многомерного:");
    int[] oneDimensionArray = CopyOneDimensionArray(newArray);
    Console.WriteLine($"{String.Join(", ", oneDimensionArray)}");
}

main();