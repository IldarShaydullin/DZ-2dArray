/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
*/

// Создать двумерный массив размером  M на N каждый элемент которого находится по формуле i + j:

/*
int[,] NewArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    }
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] result = NewArray(rows, columns);
Show2dArray(result);
*/


// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените 
// эти элементы на их квадраты.
/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

int[,] NewQuadArray(int[,] array)
{
    int[,] newQuadArray = new int[array.GetLength(0), array.GetLength(1)];
     
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if(i % 2 == 0 && j % 2 ==0)
                array[i,j]*= array[i,j]; 
    }
    return array;

}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, minValue, maxValue); 
Show2dArray(myArray); 
int[,] result = NewQuadArray(myArray);
Show2dArray(result);
*/
/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

int Diagonal (int[,] array)
{
    int sum = 0;
     
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if(i == j)
                sum = sum + array[i,j];
    }
    return sum;

}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, minValue, maxValue); 
Show2dArray(myArray); 
int sum = Diagonal(myArray);
Console.WriteLine(sum);
*/

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
 double[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1),2);
    return array;
}

void Show2dArray(double[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray(); 
Show2dArray(myArray); 
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

void ShowElement (int[,] array)
{    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("Input index i: ");
            int ind1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input index j: ");
            int ind2 = Convert.ToInt32(Console.ReadLine());
        

            if(ind1 < array.GetLength(0) && ind2 < array.GetLength(1))
                Console.WriteLine(array[ind1,ind2]);
            else
                Console.WriteLine("Данного элемента не существует");
                
        }
            
    }
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, minValue, maxValue); 
Show2dArray(myArray); 
ShowElement(myArray);
*/
 
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
      for(int i = 0; i < array.GetLength(0); i++)
      {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t ");

        Console.WriteLine();    
      }
      Console.WriteLine();
}

void Average(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
        average += array[i,j];
        } 
    average /= array.GetLength(0);     
    Console.Write(average + "\t ");  
    }
}



Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, minValue, maxValue); 
Show2dArray(myArray); 
Average(myArray);




    

