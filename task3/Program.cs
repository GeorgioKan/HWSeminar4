// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int NaturalNumberInput(string text)
{
    int number;
    Console.WriteLine(text);
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number) && number > 0)
        {
            break;
        }
        else
            System.Console.WriteLine("Введено не натуральное число. Попробуйте снова: ");
    }

    return number;
}

int NumberInput(string text)
{
    int number;
    Console.WriteLine(text);
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number))
        {
            break;
        }
        else
            System.Console.WriteLine("Введено не число. Попробуйте снова: ");
    }

    return number;
}

int[] RandomArrayCreation(int size, int leftValue, int rightValue)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftValue, rightValue + 1);
    }
    return array;
}

int size = NaturalNumberInput("Введите размер массива: ");
int leftValue = NumberInput("Введите минимальное возможное значение массива: ");
int rightValue = NumberInput("Введите максимальное возможное значение массива: ");
while (leftValue == rightValue)
    {
        Console.WriteLine("Введеные поля значений не позволяют создать массив!");
        leftValue = NumberInput("Введите минимальное возможное значение массива: ");
        rightValue = NumberInput("Введите максимальное возможное значение массива: ");
    }

int[] arr = RandomArrayCreation(size, leftValue, rightValue);

Console.WriteLine("[" + string.Join(" , ", arr) + "]");