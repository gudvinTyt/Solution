// See https://aka.ms/new-console-template for more information
using CalculatorApp;

Console.WriteLine("Калькулятор:");
bool exit = false;


do
{
    Console.WriteLine("1. Сложение (a+b)");
    Console.WriteLine("2. Вычитание (a-b)");
    Console.WriteLine("3. Умножение (a*b)");
    Console.WriteLine("4. Деление (a/b)");
    Console.WriteLine("5. Выход");
    Console.Write("Введите номер необходимого действия: ");

    int item = Convert.ToInt32(Console.ReadLine());
    double a, b;

    Calculator calc = new();
    switch (item)
    {
        case (1): //Сложение a+b
            a = Values.GetValie_A();
            b = Values.GetValie_B();
            Values.Output(calc.Addition(a, b));
            break;

        case (2): //Вычитание a-b
            a = Values.GetValie_A();
            b = Values.GetValie_B();
            Values.Output(calc.Subtraction(a, b));
            break;

        case (3): //Умножение a*b
            a = Values.GetValie_A();
            b = Values.GetValie_B();
            Values.Output(calc.Multiplication(a, b));
            break;

        case (4): //Деление a/b
            a = Values.GetValie_A();
            b = Values.GetValie_B();
            Values.Output(calc.Division(a, b));
            break;

        case (5): // Выход.
            exit = true;
            break;
    }


} while (!exit);
