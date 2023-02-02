//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] GetRandomArray (int lenght, int min, int max )
{
    int[] array = new int [lenght] ;
    for (int i=0; i<lenght; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    return array;
}

int CounEventInArray (int[] array)

{
    int count = 0;
    for (int i= 0; i <array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] array= GetRandomArray (10, 100, 999);
Console.WriteLine(string.Join(" ",array));
Console.WriteLine($" Колличество четных элементов:  {CounEventInArray(array)}");
