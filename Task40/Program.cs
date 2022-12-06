Console.WriteLine("Введите три числа для сторон треугольника: ");
Console.Write("сторона a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("сторона b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("сторона c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle(int ae, int be, int ce)
{
    return ae < be + ce && be < ae + ce && ce < ae + be;
}
bool res = Triangle(a, b, c);
Console.WriteLine(res ? "Да" : "Нет");