// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Введите кол-во строк m :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов n :  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = CreateArray ( m,  n);
PrintArray( array);
Console.WriteLine();
AverageColums ( array );

int [,] CreateArray (int m, int n)
{
    int [,] array = new int [m,n];
    for ( int i =0; i < m; i++){
        for ( int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for ( int i =0; i< array.GetLength(0); i++){
        for ( int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "    ");
        }
        Console.WriteLine();
    }
}

void  AverageColums ( int [,] array)
{
    for (int j =0; j< n; j++)
    {
        double sum =0;
        for (int i=0; i< m; i++)
        {
            sum = sum + array [i,j];
        } 
        Console.Write($"{(Math.Round(sum/m,1))}  ");
    }
}