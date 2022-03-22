
/*
//Задать массив, заполнить случайными положительными трёхзначными числами. 
 //Показать количество нечетных\четных чисел
void printArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(); 
}
int sumEven(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}
int sumOdd(int[] arr)
{
        int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 1)
        {
            sum++;
        }
    }
    return sum;
}
int[] nums = new int[10];
Random rnd = new Random();
for(int i = 0; i <nums.Length; i++)
{
    nums[i] = rnd.Next(100, 999);
}
printArr(nums);
Console.WriteLine("Количестов четных чисел в массиве: " + sumEven(nums));
Console.WriteLine("Количестов нечетных чисел в массиве: " + sumOdd(nums));
*/

/*
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
void printArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(); 
}

int sumNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 10 && arr[i] < 99)
        {
            sum++;
        }
    }
    return sum;
}

int[] nums = new int[123];

for(int i = 1; i < nums.Length; i++)
{
    nums[i] = i;
}
printArr(nums);

Console.WriteLine("Количество элементов из отрезка [10, 99] равно: " + sumNumbers(nums));
*/

 /*
 //Найти сумму чисел одномерного массива стоящих на нечетной позиции
void printArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(); 
}
int sumOdd(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}
int[] nums = new int[10];
Random rnd = new Random();
for(int i = 1; i < nums.Length; i++)
{
    nums[i] = rnd.Next(1, 10);
}
printArr(nums);

Console.WriteLine("Сумма чисел стоящих на нечетной позиции равно: " + sumOdd(nums));
*/
 
 //Найти произведение пар чисел в одномерном массиве. 
 //Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void printArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(); 
}

int multiCouple(int[] arr)
{
    int multi = 1;
    for(int i = 0; i < arr.Length/2; i++)
    {
        multi = arr[i] * arr[arr.Length-1-i];
        Console.WriteLine("Ответ: " + multi);
    }
   
    return multi;
}
int[] nums = new int[15];
Random rnd = new Random();
for(int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next(1, 9);
}
printArr(nums);

multiCouple(nums);
