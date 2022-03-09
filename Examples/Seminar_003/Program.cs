class Program
{
   public static void Main()
   {
    //     // Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
    //  int[] arr = new int[8] ;
    //     for (int i =0; i < arr.Length; i++) {
    //         if (i%2==1) arr[i] = 0;
    //     else arr[i] = 1;
    //     }
    //     foreach(int el in arr){
    //      Console.Write(el+" ");  
    //     }
    //     Console.WriteLine(".");     


    //     // Подсчитать сумму цифр в числе
    //    Console.WriteLine("Введиет число");
    //    int a = int.Parse(Console.ReadLine());
    //    int count = 0;
    //    int c = a;
    //    if(a == 0) a =1;
    //    while (a > 0)
    //    {
    //        a = a / 10;
    //        count ++;
    //    }
    //      Console.WriteLine("В числе "+c+" "+count+" цыфры");     


    //    // Найти сумму чисел от 1 до А
    //    Console.WriteLine("Введиет число A");
    //    int a = int.Parse(Console.ReadLine());
    //    int summ = 0;
    //     for(int i = 1; i <= a; i++)
    //     {
    //         summ = summ + i; 
    //     }   
    //      Console.WriteLine("Сумма чисел от 1 до {0} равна: {1}", a, summ); 


    //     // Найти кубы чисел от 1 до N
    //    Console.WriteLine("Введиет число");
    //    int n = int.Parse(Console.ReadLine());

    //     for(int i = 1; i <= n; i++)
    //     {
    //         Console.WriteLine(i * i * i + " "); 
    //     }          


        // Задать массив из 12 элементов, заполненных числами из [0,9]. 
        // Найти сумму положительных/отрицательных элементов массива
      int[] arr = new int[12];
      int sum = 0;
         for (int i =0; i < arr.Length; i++) {
             arr[i] = new Random().Next(0, 9);
         }
         foreach(int el in arr){
          Console.Write(el+" ");
          sum = sum + el;  
         }
        Console.WriteLine(".");
         Console.WriteLine("Сумма чиисел массива равна: "+sum);  

   }
}