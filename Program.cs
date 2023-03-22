//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray()
{
    int[] myArray = new int[5];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}

void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"[{myArray[i]}] ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] myArray)
{
    int evenCounter = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) evenCounter += 1;
    }
    return evenCounter;
}

int[] myArray = CreateArray();
PrintArray(myArray);
Console.WriteLine($"Количество чётных чисел массива = {CountEvenNumbers(myArray)}");
System.Console.WriteLine("=================================================");






//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int OddCounter(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

int[]array = FillArray();
PrintArray1(array);

int sum = OddCounter(array);
System.Console.WriteLine($"Сумма элементов нечётных позиций = {sum}");
System.Console.WriteLine("============================================================================");






//Задача 38: Задайте массив вещественных чисел. ыва 
//Найдите разницу между максимальным и минимальным элементов массива.

decimal[] FillArrays()
{
    decimal[] arr = new decimal[10];
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Convert.ToDecimal(new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 2));
    return arr;
}

decimal FindMin(decimal[] arr)
{
    decimal min = arr[0];
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] < min) min = arr[i];
    return min;
}

decimal FindMax(decimal[] arr)
{
    decimal max = arr[0];
    for(int i = 0; i < arr.Length; i++)
        if(arr[i] > max) max = arr[i];
    return max;
}

void PrintArray2(decimal[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
    Console.WriteLine();
}

decimal [] arr = FillArrays();
PrintArray2(arr);
System.Console.WriteLine($"Разница между {FindMin(arr)} и {FindMax(arr)} = {FindMax(arr) - FindMin(arr)}; ");
System.Console.WriteLine("============================================================================");
