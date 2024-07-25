namespace CalculatorApp.Tests
{
    public class AdditionTests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TestCase(2, 2, 4, Category = "Сложение", TestName = "2+2=4", Description ="Результат сложения 2+2")]
        [TestCase(-1, 1, 0, Category = "Сложение", TestName = "-1+1=0", Description ="Результат сложения -1+1")]
        [TestCase(0, 0, 0, Category = "Сложение", TestName = "0+0=0", Description = "Результат сложения 0+0")]

        public void Test (double a, double b, double c)
        {
            double res = calc.Addition(a, b);
            Assert.AreEqual(c, res);
        }
    }
}