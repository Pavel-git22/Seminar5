
void ShowArray(int[] array)
{
    Console.Write("Полученный массив ->:   [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght, min, max);
// ShowArray(newArray);
// Console.WriteLine();
// int[] twoArray = ChengeElrments(newArray);
// ShowArray(twoArray);
// Console.WriteLine();
// // ShowArray(newArray);

// //ShowArray(CreateRandomArray(lenght,min,max));

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateRandomArray3Nun(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}

int[] arrtest1 = CreateRandomArray3Nun(4);
ShowArray(arrtest1);





int PolNumbers(int[] arr)
{
    int Count1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            Count1++;


    }
    return Count1;
}
Console.WriteLine($"Положительные значение элемента массива:  {PolNumbers(arrtest1)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0




int[] CreateRandomArray1(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(-10, 10);
    }
    return myArray;
}

Console.WriteLine();
Console.WriteLine();
int[] arrtest2 = CreateRandomArray1(17);
ShowArray(arrtest2);

int sumElements(int[] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + arr1[i];

    }
    return sum;

}

Console.WriteLine($" сумма нечетных элементов: {sumElements(arrtest2)}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int[] CreateRandomArray2(int size)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(1, 10);
    }
    return myArray;
}

Console.WriteLine();
Console.WriteLine();
int[] arrtest3 = CreateRandomArray2(6);
ShowArray(arrtest3);

int sumRaznMinMax(int[] arr2)
{
    int sumR = 0;
    int Max= arr2[0];
    int Min = arr2[0];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] >Max)
            Max =arr2[i];
        if (arr2[i] < Min)
            Min = arr2[i];

    }
    sumR = Max -Min;
    return sumR;
}

Console.WriteLine($" сумма мин мах : {sumRaznMinMax(arrtest3)}");
