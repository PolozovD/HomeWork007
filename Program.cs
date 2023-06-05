// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// void Print2DArray (double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }    

// double[,] CreateNewArray (int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().NextDouble() + new Random().Next();
//         }
//     }
//     return array;
// }

// int rows = Prompt("Input quantity rows: ");
// int columns = Prompt("Input quantity columns: ");

// double[,] newArray = CreateNewArray(rows, columns);
// Print2DArray(newArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int Prompt (string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine();
//     int result = Math.Abs(Convert.ToInt32(value));
//     return result;
// }

// void Print2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,] CreateNewArray (int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next();
//         }
//     }
//     return array;
// }

// int rows = Prompt("Input number of rows array: ");
// int columns = Prompt("Input number of columns array: ");
// int[,] newArray = CreateNewArray(rows, columns);

// Print2DArray(newArray);
// Console.WriteLine();

// int indexRows = Prompt("Input index rows: ");
// int indexColumns = Prompt("Input index columns: ");

// if (indexRows < 0 | indexRows > newArray.GetLength(0) - 1 | indexColumns < 0 | indexColumns > newArray.GetLength(1) - 1)
// {
// Console.WriteLine("The element is not in this array  ");
// }
//     else
// {
//     Console.WriteLine($"Value of the array element -> {newArray[indexRows, indexColumns]}");
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DrandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

// double ArithmeticMeanOfElementInColumn(int[,] array)
// {
//     double sum = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//     }
//     return sum/array.GetLength(0);
// }

int[] ArithmeticMeanOfElementInColumn(int[,] array)
{
    int[] newArray = new int[array.GetLength(1)];
    newArray[j] = sum;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        return sum;
    }
    return newArray;
}


int rows = Prompt("Input value rows: ");
int columns = Prompt("input value columns: ");
int minValue = Prompt("Input minimal value: ");
int maxValue = Prompt("Input maximum value: ");

int[,] newArray = Create2DrandomArray(rows, columns, minValue, maxValue);
Print2DArray(newArray);

Console.WriteLine(ArithmeticMeanOfElementInColumn(newArray));