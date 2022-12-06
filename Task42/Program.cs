Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

string ConvertToBin(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
Console.WriteLine(ConvertToBin(number));
