// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет




int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] generateArray(int countCollums, int countLine, int a, int b)
{
    int[,] array = new int[countLine, countCollums];
    Random rndArray = new Random();
    for (int i = 0; i < countCollums; i++)
    {
        for (int m = 0; m < countLine; m++)
        {
            array[m, i] = rndArray.Next(a, b);
        }
    }
    return array;
}

(int, int) FindElement(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                return (i + 1, j + 1);
            }
        }

    }
    return (-1, -1);
}


void printMassive(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int m = 0; m < collection.GetLength(1); m++)
        {
            Console.Write($"{collection[i, m]} \t");
        }
    }
    Console.WriteLine();
}

int countCollums = enterInteger("Введите количество колоннок массива: ");
int countLine = enterInteger("Введите количество строк массива: ");


int[,] array = generateArray(countCollums, countLine, 1, 9);

printMassive(array);



int elementnumber = enterInteger("Введите нужное число: ");

(int indexRow, int indexCol) = FindElement(array, elementnumber);


if (indexRow == -1 & indexCol == -1)
{
    System.Console.WriteLine("Такого элемента нет.");
}
else
{
    System.Console.WriteLine($"Строка: {indexRow} , Колонка: {indexCol}");
}