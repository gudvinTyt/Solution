
namespace CalculatorApp.Tests
{
    public class FractionalNumbers
    {
        Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test(Description = "Результат сложения дробных чисел 2,5+2,5")]
        [Category("FractionalNumbers")]
        public void Test1()
        {
            Assert.AreEqual(5, Math.Round(calc.Addition(2.5, 2.5), 2));
        }

        [Test(Description = "Результат разности дробных чисел 5,4-2")]
        [Category("FractionalNumbers")]
        public void Test2()
        {
            Assert.AreEqual(3.4, Math.Round(calc.Subtraction(5.4, 2),2));
        }

        [Test(Description = "Результат умножения дробных чисел 3,3*9,1")]
        [Category("FractionalNumbers")]
        public void Test3()
        {
            Assert.AreEqual(30.03, Math.Round(calc.Multiplication(3.3, 9.1), 2));
        }

        [Test(Description = "Результат деления дробных чисел 15,2/4")]
        [Category("FractionalNumbers")]
        public void Test4()
        {
            Assert.AreEqual(3.8, Math.Round(calc.Division(15.2, 4), 2));
        }
    }
}
