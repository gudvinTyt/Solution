namespace CalculatorApp.Tests
{
    public class MultiplicationTests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [TestCase (3,3,9, Category ="Умножение",TestName = "3*3=9", Description = "Результат умножения 3*3")]
        [TestCase(-2, 2, -4, Category = "Умножение", TestName = "-2*2=-4", Description = "Результат умножения -2*2")]
        [TestCase(0, 5, 0, Category = "Умножение", TestName = "0*5=0", Description = "Результат умножения 0*5")]
        public void Test(double a, double b, double c)
        {
            double res = calc.Multiplication(a, b);
            Assert.AreEqual(c, res);
        }
    }
}
