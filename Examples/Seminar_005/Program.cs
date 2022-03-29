// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, b1 k1  и b2 k2 заданны


Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);

double y = k1 * ((b2-b1)/(k1-k2)) + b1;



Console.WriteLine("Точка пересечения: "+"("+ x +","+ y+")");

// ("Точка персечения: "+"("+x+","+(k1*x+b1)+")");

// Показать числа Фибоначи
int[] FiboArr = new int[10];

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

void FillArr(int[] arr)
{
    for(int i = 1; i < arr.Length; i++)
    {
        arr[i] = Fibonacci(i);
        Console.WriteLine(arr[i]);
    }
}
FillArr(FiboArr);

// Написать программу масштабирования фигуры, чтобы задавались вершины фигуры списком
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты которые получаться. 
// При k = 2 получаем "(0,0) (4, 0) (4, 4) (0, 4)"
Console.WriteLine("Введите значение X для вершины a: ");
double aX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y для вершины a: ");
double aY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение X для вершины b: ");
double bX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y для вершины b: ");
double bY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение X для вершины c: ");
double cX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y для вершины c: ");
double cY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение X для вершины d: ");
double dX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y для вершины d: ");
double dY = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Вершины фигуры равны: "+(aX, aY)+" "+(bX, bY)+" "+(cX, cY)+" "+(dX, dY));

Console.WriteLine("Введите значение коэффициэгта(2, 4 или 0,5) : ");
double k = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Вершины фигуры с коэффициэнтом "+k+" равны: "+((aX*k), (aY*k))+" "+
((bX*k),(bY*k))+" "+((cX*k),(cY*k))+" "+((dX*k), (dY*k)));