// Написать программу преобразования десятичного числа в двоичное.

Console.Clear();

Console.Write("Введите число, которое нужно преобразовать: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите основание новой системы счисления: ");
int osn = int.Parse(Console.ReadLine());
string resultReverse = "";
string result = "";

string Transform(int n, int o, string res)
{
    while (n > 0)
    {
        res += n % o;
        n /= o;
    }
    return res;
}

string Turn(string res, string change)
{
    for (int i = res.Length; i > 0; i--)
    {
        change += res[i];
    }
    return change;
}

Console.WriteLine(Transform(num, osn, resultReverse));
Console.WriteLine(Turn(resultReverse, result));