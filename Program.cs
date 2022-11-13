Console.WriteLine("Введите номер задания (1-6) (№6 - дополнительная задача из семинара): ");
int Ex = int.Parse(Console.ReadLine()!);
switch(Ex){    
    case 1:

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

        break;
    
    case 2:

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

        break;
    
    case 3:

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

        break;

case 4:
//Задача №4
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
Console.WriteLine("---------------Задание №4---------------");
Console.WriteLine("Введи кол-во элеметов по x: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во элементов по y: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи кол-во элементов по z: ");
int z1 = int.Parse(Console.ReadLine()!);

int[, ,] Array4 = GetArray3(x1, y1, z1, 10, 100);
PrintArray3(Array4);

        break;

    case 5:
//Задание №5
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
Console.WriteLine("---------------Задание №5---------------");
Console.WriteLine("Введите размерность квадратной матрицы");
int Square = int.Parse(Console.ReadLine()!);
int[,] spin = new int[Square,Square];
ArraySpinPaint(spin, Square);
PrintArray(spin);

        break;


    default:
    Console.WriteLine("Такого задания не делали");
        break;
    
    case 6:

//Задача №3
//Отсортировать нечетные столбцы массива по возрастанию и вывести оба массива: изначальный и отсортированный
Console.WriteLine("Задайте кол-во строк: ");
int a6 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте кол-во столбцов: ");
int b6 = int.Parse(Console.ReadLine()!);
int[,] array3 = GetArray(a6, b6, 0, 10);
PrintArray(array3);
Console.WriteLine();
ArraySortingColums(array3);
PrintArray(array3);

        break;

}//switch

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
    int[,] ArrayResult = GetArray(number, number, 0, 0);
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

//Метод задания одномерного массива с уникальными значениями и заполнение этими значениями трехмерного массива 
int[, ,] GetArray3(int m, int n, int l, int minValue, int maxValue){
    int size = m * n * l;
    int[] array = new int [size];
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(minValue,maxValue - 1);
    }  
        for (int sr = 0; sr <  array.Length - 1; sr ++){
            int comp = 0;
            while(comp < array.Length - 1){
                if(array[comp] == array[sr]){
                array[comp] = new Random().Next(minValue, maxValue - 1);
                comp++;
                }
                else comp++;        
            }      
        }
    
    Console.Write(String.Join(", ", array));

    Console.WriteLine();
    
    int[, ,] result = new int[m,n,l];

    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            for(int k = 0; k < l; k++){
            result[i,j,k] = array[k + 3 * j + 9 * i];                    
            }
        }
    }
    return result;
}

//Метод вывода трехмерного массива с индексом элемента
void PrintArray3(int[, ,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
            Console.Write($"{array[i,j,k], 5}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }        
    }
}

//Метод заполнения по спирали
int[,] ArraySpinPaint(int[,] array, int sq){
    int number = 1;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            while(number <= sq*sq){
                array[i,j] = number;
                if (i <= j + 1 && i + j < sq - 1)
                {
                    j++;
                }  
                else 
                if (i < j && i + j >= sq - 1) 
                {
                    i++;
                }
                else 
                if (i >= j && i + j > sq - 1) 
                {
                    j--;
                }
                else 
                i--;
                number++;
            }      
        }
    }
    return array;
}

//Метод сортировки нечетных столбцов по возрастанию
void ArraySortingColums (int[,] Array){
    int max = 1;
    int count = 0;
    for (int j = 1; j < Array.GetLength(1); j=j+2)
    {
        while (count <= Array.GetLength(0))
        {
            for (int i = 0; i < Array.GetLength(0)-1; i++)
            {
                if (Array[i + 1,j] > Array[i,j])
                {
                    max = Array[i + 1,j];
                    Array[i + 1,j] = Array[i,j];
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