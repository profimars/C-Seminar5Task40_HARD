// задача 40 - HARD необязательная. На вход программы подаются три целых 
// положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения 
// углов треугольника в градусах, является ли он прямоугольным, 
// равнобедренным, равносторонним.
//https://github.com/profimars/C-Seminar5Task40_HARD
Console.WriteLine("Введите целое положительное число a");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число b");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число c");
double c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Введенные числа a, b, c является сторонами треугольника");
    double p = a + b + c;
    Console.WriteLine("Периметр треугольника = " + p);
    double pp = p / 2;
    double ss = pp * (pp - a) * (pp - b) * (pp - c);
    double s = Math.Sqrt(ss);
    Console.WriteLine("Площадь треугольника = " + s);
    if (a == b && a == c && b == c)
    {
        Console.WriteLine("Треугольник является равносторонним");
    }
    else
    {
        if (a == b || a == c || b == c)
        {
            Console.WriteLine("Треугольник является равнобедренным");
        }
        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            Console.WriteLine("Треугольник является прямоугольным");
    }
    double t1 = (a * a + b * b - c * c) / (2 * a * b);
    double t2 = (a * a + c * c - b * b) / (2 * a * c);
    double t3 = (b * b + c * c - a * a) / (2 * b * c);
    Console.WriteLine("COS(alpha) = " + t1);
    Console.WriteLine("COS(betta) = " + t2);
    Console.WriteLine("COS(gamma) = " + t3);
    Console.WriteLine("Угол alpha = " + Math.Acos(t1) * 180 / Math.PI + " градусов");
    Console.WriteLine("Угол betta = " + Math.Acos(t2) * 180 / Math.PI + " градусов");
    Console.WriteLine("Угол gamma = " + Math.Acos(t3) * 180 / Math.PI + " градусов");

}
else
{
    Console.WriteLine("Введенные числа не является сторонами треугольника");
}

