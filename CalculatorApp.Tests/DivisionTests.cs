namespace CalculatorApp.Tests
{
    public class DivisionTests
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [TestCase(10,2,5, Category ="Деление", TestName ="10/2=5",Description = "Результат деления 10/2")]
        [TestCase(5, -1, -5, Category = "Деление", TestName = "5/-1=-5", Description = "Результат деления 5/-1")]
        [TestCase(0, 3, 0, Category = "Деление", TestName = "0/3=0", Description = "Результат деления 0/3")]
        public void Test(double a,double b,double c)
        {
            double res = calc.Division(a, b);
            Assert.AreEqual(c, res);
        }

        
        [Test(Description = "Результат деления 2/0")]
        [Category("Деление на ноль")]
        public void Test4()
        {
            Assert.AreEqual(0, calc.Division(2, 0), "Деление на ноль");
        }
        
    }
}
