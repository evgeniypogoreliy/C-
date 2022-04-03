// NextDouble() дает случайное вещественное число в диапазоне от 0 до 1

//Задача 1
// Показать двумерный массив размером m?n заполненный вещественными числами
double[,] a = new double[5, 10];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}

//Задача 2
//Задать двумерный массив следующим правилом: A[m, n] = m+n
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

void FillArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j ; 
        }
    }
}        

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr[i, j] + " ");
        }
        Console.WriteLine();   
    }  
}

FillArray(arr);
PrintArray(arr);

//Задача 3
 //Показать двумерный массив размером m?n заполненный целыми числами
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

void FillArray (int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 100); 
        }
    }
}        

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr[i, j] + " ");
        }
        Console.WriteLine();   
    }  
}

FillArray(arr);
PrintArray(arr);

// Задача 4
//В двумерном массиве n?k заменить четные элементы на противоположные
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, k];

void FillArray (int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 100); 
        }
    }
}        

void ReplaceArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        if(i % 2 == 0 && j % 2 == 0) arr[i, j] = - arr[i, j] ;
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr[i, j] + " ");
        }
        Console.WriteLine();   
    }  
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
ReplaceArray(arr);
PrintArray(arr);

// Задача 5
//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] arr = new int[3, 5];

void FillArray (int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 100); 
        }
    }
}        

void SquareArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        if(i % 2 == 0 && j % 2 == 0) arr[i, j] = arr[i, j] * arr[i, j];
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write( arr[i, j] + " ");
        }
        Console.WriteLine();   
    }  
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
SquareArray(arr);
PrintArray(arr);

// Задача 6
//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[5, 10];

void FillArray (int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            a[i, j] = random.Next(1, 100) ; 
            Console.Write( a[i, j] +" ");
        }
        Console.WriteLine();
    }
}

void ScanArray(int[,] arr, int value)
{
    Boolean scan = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if( arr[i, j] == value) 
            {
                Console.WriteLine("Заданное число находится в массиве на позиции: "+"["+i+","+j+"]");
                scan = true;
            }
        }
    }
    if(scan == false) Console.WriteLine("В данном массиве заданного числа нет");
}
FillArray(a);
ScanArray(a, n);


