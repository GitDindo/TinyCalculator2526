Console.WriteLine("== Tiny Calculator ==");

int a;
int b;
string op;
Console.WriteLine("Geben sie den Operaten an (+ - / * ^");
op = Console.ReadLine();

Console.WriteLine("Geben sie die erste Zahl an");
string number1 = Console.ReadLine();

Console.WriteLine("Geben sie die zweite Zahl an");
string number2 = Console.ReadLine();

a = int.Parse(number1);
b = int.Parse(number2);



int Calculate(int a, int b, string op)
{
    if (op == "+")
    {
        return a + b;
    }
    else if (op == "-")
    {
        return a - b;
    }
    else if (op == "*")
    {
        return a * b;
    }
    else if (op == "/")
    {
        return a / b;
    }
    else if (op == "^")
    {
        return (int)Math.Pow((double)a, (double)b);
    }

    return 0;
}