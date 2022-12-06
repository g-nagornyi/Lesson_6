
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

double IntersionPointX(double xe)
{
    return xe;
}
double IntersionPointY(double ye)
{
    return ye;
}
double res1 = IntersionPointX(x);
double res2 = IntersionPointY(y);
Console.WriteLine($"({res1}, {res2})");
