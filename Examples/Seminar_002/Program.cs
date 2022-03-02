class Program{

    static  void Main(){
        //Показать числа от -N до N
        // System.Console.WriteLine("Ввежите число n");
        // double n = Convert.ToDouble(Console.ReadLine());
        // double i = -n ;
        // while(i <= n){
        //     Console.WriteLine(i);
        //     i++;
        // }


        //Показать четные числа от 1 до N
        System.Console.WriteLine("Введите число n");
        double n = Convert.ToDouble(Console.ReadLine());
        double i = 1 ;
        while(i <= n){
            if(i % 2 == 0){
                 Console.WriteLine(i);
            }
            i++;
        }


        // //Дано число обозначающее день недели. Выяснить является номер дня недели выходным
        // System.Console.WriteLine("Введите день недели");
        // double n = Convert.ToDouble(Console.ReadLine());
        // double sa = 6;
        // double su = 7;

        // if( n == sa || n == su){
        //     System.Console.WriteLine("Выходной день");
        // }else{
        //     System.Console.WriteLine("Рабочий день");
        // }


        //  //По двум заданным числам проверять является ли одно квадратом другого
        // System.Console.WriteLine("Введите первое число: ");
        // double a = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите второе число: ");
        // double b = Convert.ToDouble(Console.ReadLine());

        // if( a == Math.Pow(b, 2)) System.Console.WriteLine("Первое число является квадратом второго");
        
        // else if( b == Math.Pow(a, 2)) System.Console.WriteLine("Второе число является квадратом первого");
        
        // else System.Console.WriteLine("Числа не связаны");  


        // //Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ? 0 и Y ? 0
        // System.Console.WriteLine("Введите значения x");
        // double x = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите значения y");
        // double y = Convert.ToDouble(Console.ReadLine());

        // if(x > 0 && y > 0) System.Console.WriteLine("Точка находится в первой четверти плоскости");
        // if(x < 0 && y > 0) System.Console.WriteLine("Точка находится в второй четверти плоскости");
        // if(x < 0 && y < 0) System.Console.WriteLine("Точка находится в третьей четверти плоскости");
        // if(x > 0 && y < 0) System.Console.WriteLine("Точка находится в четвертой четверти плоскости");


        // //Найти расстояние между точками в пространстве 3D
        // System.Console.WriteLine("Введите значения x для первой точки");
        // double x1 = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите значения y для первой точки");
        // double y1 = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите значения x для второй точки");
        // double x2 = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите значения y для второй точки");
        // double y2 = Convert.ToDouble(Console.ReadLine());
        
        // double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        // System.Console.WriteLine("Растояние между двумя точка(3D): "  + res);

        
      
    }
}
