//Сумма элементов матрицы
int rows = 2, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int SumMatrix(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
    }
    return sum;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(SumMatrix(matrix));


//Произведение элементов матрицы
int rows = 2, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int CompMatrix(int[,] arr)
{
    int comp = 1;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            comp = comp * arr[i, j];
        }
    }
    return comp;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(CompMatrix(matrix));

//Максимальный элемент матрицы
int rows = 2, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MaxElMatrix(int[,] arr)
{
    int max = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] > max) max = arr[i, j];
        }
    }
    return max;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(MaxElMatrix(matrix));

//Минимальный элемент матрицы
int rows = 2, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinElMatrix(int[,] arr)
{
    int min = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min) min = arr[i, j];
        }
    }
    return min;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(MinElMatrix(matrix));


//Сумма элементов главной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int SumDiagMatrix(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j) sum = sum + arr[i, j];
        }
    }
    return sum;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(SumDiagMatrix(matrix));


//Произведение элементов главной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int CompDiagMatrix(int[,] arr)
{
    int comp = 1;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j) comp = comp * arr[i, j];
        }
    }
    return comp;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(CompDiagMatrix(matrix));


//  Минимальный элемент, расположенный на главной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinDiagMatrix(int[,] arr)
{
    int min = arr[0, 0];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j) 
            {
                if(arr[i, j] < min) min = arr[i, j];
            }
        }
    }
    return min;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(MinDiagMatrix(matrix));


//   Сумма элементов побочной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int SumDiagSecondMatrix(int[,] arr)
{
    int sum = 0;
    int [] diag = new int[rows];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           diag[i] = arr[i, arr.GetLength(1) - 1 -i];
        }
    }
    for(int i = 0; i < diag.GetLength(0); i++)
    {
        sum = sum + diag[i];
    }
    return sum;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(SumDiagSecondMatrix(matrix));    


// Произведение элементов побочной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int CompDiagSecondMatrix(int[,] arr)
{
    int comp = 1;
    int [] diag = new int[rows];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           diag[i] = arr[i, arr.GetLength(1) - 1 -i];
        }   
    }
    for(int i = 0; i < diag.GetLength(0); i++)
    {
        comp = comp * diag[i];
    }
    return comp;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(CompDiagSecondMatrix(matrix));
    

// Максимальный элемент, расположенный на побочной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MaxDiagSecondMatrix(int[,] arr)
{
    int max = arr[0, 0];
    int [] diag = new int[rows];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           diag[i] = arr[i, arr.GetLength(1) - 1 -i];
        }   
    }
    for(int i = 0; i < diag.GetLength(0); i++)
    {
        if(diag[i] > max) max = diag[i];
    }
    return max;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(MaxDiagSecondMatrix(matrix));


//  Минимальный элемент, расположенный на побочной диагонали матрицы
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinDiagSecondMatrix(int[,] arr)
{
    int min = arr[0, 0];
    int [] diag = new int[rows];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           diag[i] = arr[i, arr.GetLength(1) - 1 -i];
        }   
    }
    for(int i = 0; i < diag.GetLength(0); i++)
    {
        if(diag[i] < min) min = diag[i];
    }
    return min;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine(MinDiagSecondMatrix(matrix));
    

//  Поиска минимального из максимальных элементов матрицы, 
// то есть найти максимальный элемент в каждой из строк матрицы 
// и из них выбрать минимальный
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)

{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int maxArray(int[] arr)
{
   int max = arr[0];
   for(int i = 0; i < arr.Length; i++)
   {
       if(arr[i] > max) max = arr[i];
   }
   return max; 
}
int MinMaxRowsMatrix(int[,] arr)
{
    int max1rows = arr[0, 0];
    int max2rows = arr[1, 0];
    int max3rows = arr[2, 0];
    int min = arr[0, 0];
    int [] row1 = new int[rows];
    int [] row2 = new int[rows];
    int [] row3 = new int[rows];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           if(i == 0){
               row1[i] = arr[i, j];
           }
           if(i == 1){
               row2[i] = arr[i, j]; 
           }
           if(i == 2){
               row3[i] = arr[i, j]; 
           }   
        }      
    }
    max1rows = maxArray(row1);
    max2rows = maxArray(row2);
    max3rows = maxArray(row3);
    Console.WriteLine("1 rows max :"+max1rows); 
    Console.WriteLine("2 rows max :"+max2rows);
    Console.WriteLine("3 rows max :"+max3rows);
    if(max1rows < min) min = max1rows;
    if(max2rows < min) min = max2rows;
    if(max3rows < min) min = max3rows;

    return min;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
Console.WriteLine("Min element of the maximum: "+MinMaxRowsMatrix(matrix));


//  Транспонирование для квадратной матрицы, то есть переворот матрицы 
//относительно главной диагонали
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)

{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TransMatrix(int[,] arr)
{
    int[,] tMatrix = new int[rows, colums];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            tMatrix[i,j] = arr[j,i];
         
        }      
    }
    return tMatrix;
}
FillMatrix(matrix, minArrayElement, maxArrayElement);
PrintMatrix(matrix);
PrintMatrix(TransMatrix(matrix));

//  Сумма двух матриц одинаковых размерностей
int rows = 3, colums = 3;
int minArrayElement = 0, maxArrayElement = 9;
int[,] matrix1 = new int[rows, colums];
int[,] matrix2 = new int[rows, colums];
void FillMatrix(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(startEl, endEl +1);
        }
    }
}
void PrintMatrix(int[,] arr)

{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SumMatrix(int[,] arr1, int [,] arr2)
{
    int[,] tMatrix = new int[rows, colums];
    for(int i = 0; i < tMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tMatrix.GetLength(1); j++)
        {
            tMatrix[i, j] = arr1[i, j] + arr2[i, j];
         
        }      
    }
    return tMatrix;
}
FillMatrix(matrix1, minArrayElement, maxArrayElement);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix1);
FillMatrix(matrix2, minArrayElement, maxArrayElement);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(matrix2);
Console.WriteLine("Сумма двух матриц: ");
PrintMatrix(SumMatrix(matrix1, matrix2));


    