// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Введите кол-во строк m :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов n :  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки row :  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца colum :  ");
int colum = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateArray (m,n);
PrintArray (array);
Console.WriteLine();
FindItem (array, row, colum);

int [,] CreateArray (int m, int n)
{
    int [,] array = new int [m,n];
    for ( int i =0; i < m; i++){
        for ( int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(0, 30);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for ( int i =0; i< array.GetLength(0); i++){
        for ( int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "  ");
        }
        Console.WriteLine();
    }
}

 void FindItem (int [,] array,int row, int colum)
{
    if ( row > m-1 || colum > n-1) {
        Console.WriteLine ($"Элемента с позицией {row},{colum}  нет");
    }
    else
    {
        Console.WriteLine ($"Элемент с позицией {row},{colum} = {array [row,colum]}");
    }    
}
