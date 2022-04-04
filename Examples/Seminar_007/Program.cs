//Задача 1
//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine("Введите минимальное значение интервала заполнения: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение интервала заполнения: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int colum = Convert.ToInt32(Console.ReadLine());
if(colum != row)
{
    Console.WriteLine("Заданная матрица не квадратная"); 
    return; 
}  
Console.WriteLine();
int[,] matrix = new int[colum, row];

void FillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] arr)
{
   for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    } 
}

void ReplaceColumRow(int[,] arr)
{
    int temp;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = i + 1; j < arr.GetLength(1); j++)
        {
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
 
    }
}

FillArray(matrix, startNumber, endNumber);
PrintArray(matrix);
Console.WriteLine();
ReplaceColumRow(matrix);
PrintArray(matrix);
Console.WriteLine();


//Задача 2
//Найти произведение двух матриц
Console.WriteLine("Введите минимальное значение интервала заполнения: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение интервала заполнения: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в матрице: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int colum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в матрице: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int colum2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[colum1, row1];
int[,] matrix2 = new int[colum2, row2];

if(colum1 != row2 || colum2 != row1)
{
    Console.WriteLine("Заданные матрици нельзя перемножить!");
    return;
}

void FillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] arr)
{
   for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    } 
}

int[,] MultiMatrix(int[,] arr1, int[,] arr2)
{
    int[,] m = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for(int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                m[i, k] += arr1[i, j] * arr2[j, k];
            }    
        }
    }
    return m;     
}

FillArray(matrix1, startNumber, endNumber);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2, startNumber, endNumber);
PrintArray(matrix2);
Console.WriteLine();
PrintArray(MultiMatrix(matrix1, matrix2));


//Задача 3
//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно
// на экран выводя индексы соответствующего элемента
int[, ,] arr = new int[3, 3, 3];

void FillArray(int[, ,] ar)
{
    Random rnd = new Random();
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int k = 0; k < ar.GetLength(2); k++)
            {
                ar[i, j, k] = rnd.Next(1, 100);
                if(ar[i, j, k] == ar[i, j, k]-1) ar[i, j, k] = rnd.Next(1, 100);
            }
        }
    }               
}

void PrintArray(int[, ,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int k = 0; k < ar.GetLength(2); k++)
            {
                Console.Write(ar[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }               
}

FillArray(arr);
PrintArray(arr);


//Задача 4
//Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n = Convert.ToInt32(Console.ReadLine());

float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;
}

void Pascal(int stroca)
{
    for (int i = 0; i < stroca; i++)
    {
        for (int j = 0; j <= (stroca - i); j++) 
        {
            Console.Write(" "); 
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" "); 
            Console.Write(factorial(i) / (factorial(j) * factorial(i - j))); 
        }
        Console.WriteLine();
        Console.WriteLine(); 
    }
    Console.ReadLine();    

}

Pascal(n);
