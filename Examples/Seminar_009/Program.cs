//Найти сумму цифр числа
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int Summa(int num)
{
    if(num / 10 >= 1)
    {
        int a = num % 10;
        int b = num / 10;
        return a + Summa(b);

    } 
    return num;
}

Console.WriteLine("Сумма цифр в введенном числе равна: " + Summa(n));

// Написать программу вычисления функции Аккермана
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
int A(int n, int m)
{
    if(n == 0) return m + 1;
    if(n != 0 && m == 0) return A(n -1 , 1);
    if(n > 0 && m > 0) return A(n -1, A(n, m - 1));
    return A(n, m);
}
Console.WriteLine(A(n, m));


//Написать программу возведения числа А в целую стень B
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());

int Pow(int num1, int num2)
{
    int num = 1;
    if(num2 > 0)
    {
        num = num1 * Pow(num1, num2 - 1);
        
    }

    return num; 
}

Console.WriteLine("Число A в степени B равно: " + Pow(a, b));


//Написать программу показывающие первые N чисел, для которых каждое следующее
// равно сумме двух предыдущих. Первые два элемента последовательности задаются
// пользователем
Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество чисел N: ");
int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
int Sum( int a, int b)
{
    int num = 0;
     num = a + b;
    return num; 
}
void FillArray(int[] arr)
{
    arr[0] = firstNum;
    arr[1] = secondNum;
    for(int i = 2; i < arr.Length; i++)
    {
        arr[i] = Sum(arr[i - 1], arr[i - 2]);
    }
}
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(i+" чило равно: " + arr[i]);
    }
}
FillArray(nums);
PrintArray(nums);