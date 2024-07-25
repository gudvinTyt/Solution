namespace CalculatorApp
{
    static class Values
    {
        
        static public double GetValie_A ()
        {
            Console.Write("Введите значение 'а' - ");
            _ = double.TryParse(Console.ReadLine(), out var namber);

            return namber;
        }
        static public double GetValie_B()
        {
            Console.Write("Введите значение 'b' - ");
            _ = double.TryParse(Console.ReadLine(), out var namber);

            return namber;
        }

        static public void Output (double result)
        {
            Console.Write($"Результат равен - {result}");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
