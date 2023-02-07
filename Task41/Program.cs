// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string NumberInput(string text)
{
    Console.Write($"{text}: ");
    string numbers = Console.ReadLine();
    return numbers;
}

int[] ArrayNumbers(string num)
{
    char[] separators = new char[] {',', ' '};
    string[] array = num.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = int.Parse(array[i]);
    }
    return newArray;
}

int NumberPositiveCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) count++; 
    }
    return count;
}

void PrintResult(int[] numArray, int countPositiveNum)
{
    Console.WriteLine($"Вы ввели числа ({String.Join(", ", numArray)})");
    Console.WriteLine($"Из них {countPositiveNum} больше нуля");
}

void main()
{
    Console.Clear();
    string num = NumberInput("Введите цифры через пробел или запятую");
    int[] numArray = ArrayNumbers(num);
    int countPositiveNum = NumberPositiveCount(numArray);
    PrintResult(numArray, countPositiveNum);
}

main();