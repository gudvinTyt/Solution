namespace CalculatorApp
{
    public class Calculator
    {

        public double Addition(double a, double b)
        {
            return a + b;
        }
  
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
       
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
      
        public double Division(double a, double b)
        {
            if (b==0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
                
            }
            else
            {
                return a/b;
            }
        }
     
    }
}
    