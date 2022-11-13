
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
