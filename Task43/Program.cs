// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Input(string text)
{
    Console.Write($"{text}: ");
    int numbers = int.Parse(Console.ReadLine());
    return numbers;
}

void IntersectionPoint(double k1,double k2,double b1,double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2) Console.Write("Прямые совпадают");
        else Console.Write("Прямые паралельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2); 
        double y = k2 * x + b2;
        Console.Write($"Координаты точки пересечения: ({x}; {y})");
    }
}

void main()
{
    Console.Clear();
    Console.WriteLine("Вам необходимо ввести координаты точек k и b");
    int k1 = Input("Введите значение k1");
    int b1 = Input("Введите значение b1");
    int k2 = Input("Введите значение k2");
    int b2 = Input("Введите значение b2");
    IntersectionPoint(k1, k2, b1, b2);
}

main();