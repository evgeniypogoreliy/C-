class Program {
    static void Main(){
        //Найти максимальное из трех чисел

        // System.Console.WriteLine("Введите  число");
        // double a = Convert.ToDouble(Console.ReadLine());

        // double res = Math.Pow(a, 2);

        // System.Console.WriteLine("Квадрат введеного числа: "+res);


        //Найти максимальное из трех чисел

        // System.Console.WriteLine("Введите первое число");
        // double a = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите второе число");
        // double b = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Введите третье число");
        // double c = Convert.ToDouble(Console.ReadLine());

        // double max = a;

        // if(b > max) max = b;
        // if(c > max) max =c;

        // System.Console.WriteLine("Максимальное число "+max);


        //Выяснить является ли число чётным
        
        // System.Console.WriteLine("Введите  число");
        // double a = Convert.ToDouble(Console.ReadLine());

        // double res = a % 2;

        // if (res == 0)
        // System.Console.WriteLine("Введенное число является четным");
        // else 
        // System.Console.WriteLine("Введенное число является не четным");


        //Показать последнюю цифру трёхзначного числа

        // System.Console.WriteLine("Введите трехзначное число");
        // double a = Convert.ToDouble(Console.ReadLine());
        // if(a >= 100 && a < 1000)
        // {
        //     double res = a % 10;
        // System.Console.WriteLine("Последня цифра числа "+ res);
        // }else
        // System.Console.WriteLine("Введенное число не является трехзначиным");

        //Показать вторую цифру трёхзначного числа

        // System.Console.WriteLine("Введите трехзначное число");
        // double a = Convert.ToDouble(Console.ReadLine());
        // if(a >= 100 && a < 1000)
        // {
        //     double b = a / 10;
        //     double c = Math.Floor(b);
        //     int res = Convert.ToInt32(c % 10);

        // System.Console.WriteLine("Вторая цифра числа "+ res);
        // }else
        // System.Console.WriteLine("Введенное число не является трехзначиным");


        //Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

        // int a = new Random().Next(10,99);
        // System.Console.WriteLine("Случайное число из указанного отрезка: "+ a);
        // int b = a / 10;
        // int c = a % 10;

        // int max = b;
        // if(c > max) max = c;

        // System.Console.WriteLine("Наибольшая цифра из взятого числа равна "+ max);


        //Удалить вторую цифру трёхзначного числа
        int a = new Random().Next(100,999);
        System.Console.WriteLine("Случайное трехзначное число "+a);
        int b = a / 100;
        int c = a % 10;

        String res = Convert.ToString(b) + Convert.ToString(c);

        int res2 = Convert.ToInt16(res);
        System.Console.WriteLine("Результат удаления второй цифры "+ res2);


       //Выяснить, кратно ли число заданному, если нет, вывести остаток

        // int a = new Random().Next(1,100);
        // System.Console.WriteLine("Заданное число: "+ a);
        // System.Console.WriteLine("Введите число от 1 до 100");
        // double b = Convert.ToDouble(Console.ReadLine());
        // int _b = Convert.ToInt16(b);

        // int res = a % _b;

        // if(res == 0) 
        // System.Console.WriteLine("Введенное число кратно заданному");

        // else 
        // System.Console.WriteLine("Остаток "+ res);

       
        //Найти третью цифру числа или сообщить, что её нет
        
        // System.Console.WriteLine("Введите число");
        // double a = Convert.ToDouble(Console.ReadLine());
        // System.Console.WriteLine("Число "+a);
        
        // if(a >= 100)
        // {
        // double res = Math.Abs(a) % 10;
        // System.Console.WriteLine("Третья цифра "+ res);
        // }else 
        // System.Console.WriteLine("В введенном числе нет третьей цифры");    
    }
}