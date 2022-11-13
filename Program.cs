
//Задание №1 (54) 
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("--------------------Задание №1 (54)--------------------");
Console.WriteLine("Задайте кол-во строк: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кол-во столбцов: ");
int b1 = int.Parse(Console.ReadLine()!);
int[,] array1 = GetArray(a1, b1, 0, 10);
PrintArray(array1);
Console.WriteLine();
ArraySorting(array1);
PrintArray(array1);


//Задание №2 (56) 
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("--------------------Задание №2 (56)--------------------");
Console.WriteLine("Задайте кол-во строк: ");
int a2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кол-во столбцов: ");
int b2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetArray(a2, b2, 0, 10);
PrintArray(array2);
Console.WriteLine();
SearchSum(array2);


//Задание №3 (58)
//Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Задайте размерность первой и второй квадратным матрицам: ");
int a3 = int.Parse(Console.ReadLine()!);
int[,] array31 = GetArray(a3, a3, 0, 10);
int[,] array32 = GetArray(a3, a3, 0, 10);
Console.WriteLine("Первая матрица A: ");
PrintArray(array31);
Console.WriteLine("Вторая матрица B: ");
PrintArray(array32);
Console.WriteLine("Произведение матриц А и B: ");
CompositionArray(array31, array32, a3);


//Методы
int[,] GetArray(int num1, int num2, int minValue, int maxValue)
{
    int[,] result = new int[num1,num2];
    for (int i = 0; i < num1; i++)
    {
        for (int j = 0; j < num2; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue); 
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j], 3}");
        }
        Console.WriteLine();
    }
}

//Метод сортировки строк по возрастанию
void ArraySorting (int[,] Array)
{
    int max = 1;
    int count = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        while (count <= Array.GetLength(1))
        {
            for (int j = 0; j < Array.GetLength(1) - 1; j++)
            {
                if (Array[i,j + 1] > Array[i,j])
                {
                    max = Array[i,j + 1];
                    Array[i,j + 1] = Array[i,j];
                    Array[i,j] = max;
                    max = 0;
                }
            }
            count++;
            max = 0;
        }
        count = 0;
        max = 0;
    }
}

//Метод нахождения наименьшей суммы в строке матрицы
void SearchSum (int[,] Array)
{
    int temp = 99999; //Просто не знаю как приравнять первую строку к temp
    int sum = 0;
    int count = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
               sum += Array[i,j];
        }    

        if (sum < temp)
        {
            temp = sum;
            count = i + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с минимальной суммой эдементов в матрице является строка №{count} и ее сумма = "+ temp);
}

//Метод перемножения квадратных матриц
void CompositionArray(int[,] Array1, int[,] Array2, int number)
{
    int[,] ArrayResult = GetArray(a3, a3, 0, 0);
    int k = 0;
    for (int i = 0; i < Array1.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    while(k < Array2.GetLength(0))
                    {
                        ArrayResult[i,j] += Array1[i,k] * Array2[k,j];
                        k++;
                    }
                    Console.Write($"{ArrayResult[i,j],3} ");
                    k = 0;
                }
                Console.WriteLine();
            }
}