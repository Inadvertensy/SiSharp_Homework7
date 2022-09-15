Console.WriteLine("Please enter number of task");
int Name = Convert.ToInt32(Console.ReadLine());

switch (Name)
{
    case 47:
        // Задача 47: Задайте двумерный массив размером m×n, 
        // заполненный случайными вещественными числами.

        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9

        Console.Clear();
        Console.WriteLine("Task 47 is displaying");

        Console.WriteLine("Please insert number of rows in array");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert number of columns in array");
        int columns = int.Parse(Console.ReadLine());

        double[,] array = GetArray(rows, columns, 0, 10);
        PrintArray(array);

        double[,] GetArray(int rows, int columns, double minValue, double maxValue)
        {
            double[,] result = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = new Random().NextDouble() * (maxValue - minValue);
                }
            }
            return result;
        }

        void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]:f3} ");
                }
                Console.WriteLine();
            }
        }
        break;

    case 50:

        // Задача 50: Напишите программу, которая на вход 
        // принимает позиции элемента в двумерном массиве, и 
        // возвращает значение этого элемента или же указание, 
        // что такого элемента нет.

        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет

        Console.Clear();
        Console.WriteLine("Task 50 is displaying");

        Console.WriteLine("Please insert number of rows in array");
        int rows2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert number of columns in array");
        int columns2 = int.Parse(Console.ReadLine());

        int[,] array2 = GetArray2(rows2, columns2, 0, 10);

        PrintArray2(array2);
        FindNumber(array2);

        int[,] GetArray2(int rows2, int columns2, int minValue2, int maxValue2)
        {
            int[,] result = new int[rows2, columns2];
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    result[i, j] = new Random().Next(minValue2, maxValue2 + 1);
                }
            }
            return result;
        }

        void PrintArray2(int[,] array2)
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write($"{array2[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        break;

        void FindNumber(int[,] array2)
        {
            Console.WriteLine("Please enter row of number that you want to know");
            int posRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter column of number that you want to know");
            int posCol = Convert.ToInt32(Console.ReadLine());


            if (posRow <= array2.GetLength(0) && posCol <= array2.GetLength(1))
            {

                Console.WriteLine();
                Console.WriteLine($"Number you are looking for is...\t{array2[posRow, posCol]}");
            }
            else
            {
                Console.WriteLine("There is no such row and column in array");
            }


        }


    case 52:
        // Задача 52: Задайте двумерный массив из целых чисел. 
        // Найдите среднее арифметическое элементов в каждом 
        // столбце

        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // Среднее арифметическое каждого 
        // столбца: 4,6; 5,6; 3,6; 3
        Console.Clear();

        Console.WriteLine("Please insert number of rows in array");
        int rows3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please insert number of columns in array");
        int columns3 = int.Parse(Console.ReadLine());

        int[,] array3 = GetArray3(rows3, columns3, 0, 10);
        PrintArray3(array3);

        int[,] GetArray3(int rows3, int columns3, int minValue3, int maxValue3)
        {
            int[,] result3 = new int[rows3, columns3];
            for (int i = 0; i < rows3; i++)
            {
                for (int j = 0; j < columns3; j++)
                {
                    result3[i, j] = new Random().Next(minValue3, maxValue3 + 1);
                }
            }
            return result3;
        }

        void PrintArray3(int[,] array3)
        {
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write($"{array3[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        void ArithmeticMean(int[,] array3)
        {
            double arMn=0;
            double sumIJ = 0;
            int Count=0;
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    sumIJ = sumIJ + array3[i, j];
                    Count++;  
                    if (Count==array3.GetLength(1))
                    {
                        arMn = sumIJ / array3.GetLength(1);
                        Console.WriteLine($"Arithmetic mean of row {i} is {arMn:f3}");
                    }
                }
                Console.WriteLine();
                sumIJ=0;
                Count=0;   
            }
        }
        ArithmeticMean(array3);
        break;
    default:
        Console.WriteLine("Bye-bye");
        break;
}