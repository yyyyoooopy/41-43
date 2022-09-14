// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows  = Convert.ToInt32(Console.ReadLine()); // int.Parse == Convert.ToInt32
// Console.WriteLine();

// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// int [,] matrix = new int [rows,columns];

// for(int i =0; i<matrix.GetLength(0); i++)
// {
//     for(int j =0; j<matrix.GetLength(1); j++)
//     {   
//         matrix[i,j] = new Random().Next(0,11);
//         Console.Write(matrix[i,j]+ "\t"); // вместо пробела " " можно поставить "\t"
//     }
//     Console.WriteLine();
// }
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// int rows = int.Parse(Console.ReadLine());
// int columns =Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// 	for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i + j;
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows,columns];

// Console.WriteLine("Первоначальный массив:");
// for(int i=0; i<rows; i++)
// {
// 	for(int j=0; j<columns; j++)
// 	{
// 		array[i, j] = new Random().Next(1, 100);
// 		Console.Write(array[i,j] + "\t");
// 	}
// 	Console.WriteLine();
	
// }
// Console.WriteLine();
// int rows = int.Parse(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(1,11);
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if(i%2==0 && j%2==0)
//         {
//             matrix[i,j] = Math.Pow(matrix[i,j],2);
//         }
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int rows = Convert.ToInt32(Console.ReadLine());
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int[rows, columns];
// int sum = 0;
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = new Random().Next(0, 10);
//         if (i == j)
//         {
//             sum +=matrix[i,j] ;
//         }
//         Console.Write(matrix[i, j] + "\t");
// c
// Console.WriteLine($"Сумма = {sum}");

	// Задача 53: Задайте двумерный массив.
    // Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Console.WriteLine("Первоначальный массив:");
// int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		array[i, j] = new Random().Next(0, 10);
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }

// int[] temp = new int[array.GetLength(1)];

// for(int k=0; k<array.GetLength(1); k++)
// {
// 	temp[k]=array[0, k];
// 	array[0, k]= array[array.GetLength(0)-1, k];
// 	array[array.GetLength(0)-1, k] = temp[k];
// }

// Console.WriteLine("Новый массив:");

// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }

// //Задача 55: Задайте двумерный массив. Напишите программу,
//  которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// int[,] array = new int[3, 3];

// Console.WriteLine("Первоначальный массив:");
// for(int i=0; i<array.GetLength(0); i++)
// {
// 	for(int j=0; j<array.GetLength(1); j++)
// 	{
// 		array[i, j] = new Random().Next(0, 10);
// 		Console.Write(array[i, j] + "\t");
		
// 	}
// 	Console.WriteLine();
// }

// Console.WriteLine("Новый массив:");
// if (array.GetLength(0)== array.GetLength(1))
// {
// 	for(int i=0; i<array.GetLength(0); i++)
// 	{
// 		for(int j=0; j<array.GetLength(1); j++)
// 		{
// 			Console.Write(array[j, i] + "\t");
// 		}
// 		Console.WriteLine();
// 	}
// }
// else Console.WriteLine("Невозможно сделать замену.");


// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// int rows = 3;
// int columns = 3;
 
// int[,] matrix = new int[rows, columns];
 
// int minValue = int.MaxValue; 
// int minIndexRows = 0;        
// int minIndexColumns = 0;   
 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//         if (minValue > matrix[i, j])
        
//         {
//             minValue = matrix[i, j];
//             minIndexRows = i;
//             minIndexColumns = j;
//         }
 
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Минимум:" + minValue);
// System.Console.WriteLine("Результат:");
// for (int i = 0; i < rows; i++) // rows = GetLength(0)
// {
//     if (i != minIndexRows)
//     {
//         for (int j = 0; j < columns; j++) //columns - GetLength(1)
//         {
//             if (j != minIndexColumns)
//             {
//                 Console.Write(matrix[i,j] + "\t");
 
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника.
