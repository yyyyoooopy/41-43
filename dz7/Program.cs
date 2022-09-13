
// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

 
// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[rows, columns];

//  for (int i = 0; i < rows; i++)
//  {
//      for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         Console.Write(matrix[i,j] + "\t");
//     }
//  }
//  Console.WriteLine();


// Задача 50. Напишите программу,
//  которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j <columns; j++)
//     {
//         matrix[i,j] = new Random().Next(10,100);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// Console.WriteLine("Введите номер строки: ");
// int numberRows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца: ");
// int numberColumns = Convert.ToInt32(Console.ReadLine());

// if(rows<numberRows|| columns<numberColumns)
// {
//   Console.WriteLine(" Такого числа в массиве нет"));
// }
// else
// {
//    Console.WriteLine(matrix [ numberRows-1;  numberColumns-1])); 
// }


// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 
Random random = new Ramdom;
int[,] matrix = new int [random.Next(1,10), random.Next(1,10)];
for (int i=0; i< matrix.GetLength(0); i++)
{
    for(int j=0;j< matrix.GetLength(1); j++)
    {
        matrix [i;j]=random.Next(1,10);
        Console.Write(matrix [i;j]+"");
    }
    Console.WriteLine();

}
Console.WriteLine("----------------------");
for(int j=0;j< matrix.GetLength(1);j++)
{
    double sum =0;
    for (int i=0; i< matrix.GetLength(0); i++)
    {
        sum+= matrix [i;j];
    }
    Console.Write($"{Math.Round(sum/matrix.GetLength(0)2)}")});
}
