using Calculator_.NET_6._0;

Calc calc = new Calc();
bool exit = false;
while (!exit) // istället för "exit == false"
{
    double sum = 0;
    bool divZero = false;
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\r\n\t\t\t+-*/ BASIC CONSOLE CALCULATOR /*-+\r\n");
    Console.ResetColor();

    Console.Write("Choose operand A followed by operation and operand B. ");
    Console.WriteLine("Write \"e\" to exit at any time.\r\n\r\n" +

        "\t+ : Addition\t\tA + B\r\n" +
        "\t- : Subtraction\t\tA - B\r\n" +
        "\t* : Multiplication\tA * B\r\n" +
        "\t/ : Division\t\tA / B\r\n");

    Console.Write("A: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string a = Console.ReadLine();
    if (Exiting(a)) { exit = true; goto ending; }
    double A = double.Parse(a);

    Console.ResetColor();
    Console.Write("O: ");
    Console.ForegroundColor = ConsoleColor.Green;
    char op = Char.ToLower(char.Parse(Console.ReadLine())); // Se till att både gemener och versaler fungerar

    Console.ResetColor();
    Console.Write("B: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string b = Console.ReadLine();
    if (Exiting(b)) { exit = true; goto ending; }
    double B = double.Parse(b);
    Console.ResetColor();

    switch (op)
    {
        case '+':
            sum = calc.Add(A, B);
            break;


        case '-':
            sum = calc.Sub(A, B);
            break;


        case '*':
            sum = calc.Mul(A, B);
            break;


        case '/':
            if (B == 0)
            {
                divZero = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\r\nDivision by zero is not allowed!");
                Console.ResetColor();
                break;
            }
            sum = calc.Div(A, B);
            break;
        case 'e':
            exit = true;
            break;
    }
    if (!divZero)
    {
        Console.Write("\r\nSUM = ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(sum);
        Console.ResetColor();
    }

    Console.WriteLine("\r\nPress any button to continue.");
    Console.ReadKey();
ending:
    Console.Clear();
}
Boolean Exiting(string e)
{
    Boolean E = false;
    if (e == "e")
    {
        E = true;
        return E;
    }
    return E;
}
