// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.WriteLine("Введите кол-во строк m :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов n :  ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m, n]; 
CreateArray ( m,n);
PrintArray (array);

void  CreateArray (int m, int n)
{
    for ( int i =0; i < m; i++){
        for ( int j = 0; j < n; j++)
        {
            array [i,j] = Convert.ToDouble(new Random().Next (-10, 20))/10;
        }
    }
}

void PrintArray (double [,] array)
{
    for ( int i =0; i< array.GetLength(0); i++){
        for ( int j =0; j < array.GetLength(1); j++)
        {
             Console.Write (Math.Round(array [i ,j],1)   + "  ");
        }    
        Console.WriteLine();
    }
}