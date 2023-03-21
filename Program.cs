//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    int[] arr = new int[5];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int CountNumbers(int[] arr)
{
    int evenCounter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCounter += 1;
    }
    return evenCounter;
}


int[] arr = CreateArray();
PrintArray(arr);
Console.WriteLine($"Количество чётных чисел массива = {CountNumbers(arr)}");
System.Console.WriteLine();
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray()
{
    int[] arr = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int OddCounter(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

void PrintArray1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

arr = FillArray();
PrintArray1(arr);

int sum = OddCounter(arr);
System.Console.WriteLine($"Сумма элементов нечётных позиций = {sum}");
System.Console.WriteLine();

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

decimal[] FillArrays()
{
    decimal[] arr = new decimal[10];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDecimal(new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 2));
    }
    return arr;
}
decimal FindMin(decimal[] arr)
{
    decimal min = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

decimal FindMax(decimal[] arr)
{
    decimal max = arr[0];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

void PrintArray2(decimal[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

decimal [] arrr = FillArrays();
PrintArray2(arrr);
decimal result = FindMax(arrr) - FindMin(arrr);
System.Console.WriteLine($"Разница между {FindMin(arrr)} и {FindMax(arrr)} = {result}; ");