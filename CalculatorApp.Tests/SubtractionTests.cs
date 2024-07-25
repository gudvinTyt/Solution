
namespace CalculatorApp.Tests
{
    public class SubtractionTests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [TestCase (5, 3, 2,Category ="Разность", TestName ="5 - 3 = 2", Description = "Результат вычитания 5-3")]
        [TestCase(0, 4, -4, Category = "Разность", TestName = "0 - 4 = -4", Description = "Результат вычитания 0-4")]
        [TestCase(-2, -2, 0, Category = "Разность", TestName = "-2 - (-2) = 0", Description = "Результат вычитания -2-(-2)")]
        public void Test(double a, double b, double c)
        {
            double res = calc.Subtraction(a, b);
            Assert.AreEqual(c, res);
        }
    }
}
