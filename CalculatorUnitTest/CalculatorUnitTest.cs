using CalculatorClassLibrary;


namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        CalculatorCL calculator = new CalculatorCL();

        [TestInitialize]
        public void Initialize()
        {
            calculator = new CalculatorCL();
        }

        [TestMethod]
        public void Add_WhenBothNumbersArePositive_ShouldReturnCorrectPositiveResult()
        {
            decimal result = calculator.Add(2.5m, 3.5m);

            // Assert result is positive with 2.5 + 3.5 = 6.0
            Assert.AreEqual(6m, result);
        }

        [TestMethod]
        public void Add_WhenBothNumbersAreNegative_ShouldReturnCorrectNegativeResult()
        {
            decimal result = calculator.Add(-2.5m, -3.5m);

            // Assert result is negative with -2.5 - 3.5 = -6.0
            Assert.AreEqual(-6m, result);
        }

        [TestMethod]
        public void Add_WhenOneNumberIsZero_ShouldReturnOtherNumber()
        {
            decimal result1 = calculator.Add(0m, 5.5m);
            decimal result2 = calculator.Add(-3.3m, 0m);

            // Assert result is non zero 
            Assert.AreEqual(5.5m, result1);
            Assert.AreEqual(-3.3m, result2);
        }

        [TestMethod]
        public void Add_WhenOneNumberIsPositiveAndOneIsNegative_ShouldReturnCorrectResult()
        {
            decimal result = calculator.Add(2.5m, -3.5m);
            Assert.AreEqual(-1m, result);
        }

        [TestMethod]
        public void Add_WhenNumbersAreLarge_ShouldReturnCorrectResult()
        {
            decimal result = calculator.Add(999999999999999999.5m, 0.5m);

            Assert.AreEqual(1000000000000000000m, result);
        }


        /** From here we start the unit tests for the Subtract method */

        [TestMethod]
        public void Subtract_WhenFirstNumberIsBigger_ShouldReturnPositive()
        {
            decimal result = calculator.Subtract(5.5m, 3.5m);

            // Assert result is positive with 5.5 - 3.5 = 2.0 > 0
            Assert.IsTrue(result > 0, $"Expected a positive value, but got {result}");
        }

        [TestMethod]
        public void Subtract_WhenBothNumbersAreNegative_ShouldReturnOppositeSignResultWithBiggerNumber()
        {
            // Act
            decimal result = calculator.Subtract(-2m, -3m);
            decimal result1 = calculator.Subtract(-5m, -3m);


            // Assert result is positive (opposite sign) with -2 - (-3) = 1 >  0
            Assert.IsTrue(result > 0, $"Expected a positive value, but got {result}");

            // Assert result is negative (opposite sign) with -5 - (-3) = -2 <  0
            Assert.IsFalse(result1 > 0, $"Expected a negative value, but got {result1}");
        }

        [TestMethod]
        public void Subtract_WhenSecondNumberisBigger_ShouldReturnNegative()
        {
            decimal result = calculator.Subtract(5m, 10m);

            Assert.IsTrue(result < 0, $"Expected a positive value, but got {result}");

        }

        [TestMethod]
        public void Subtract_WhenIncorrectResult_ShouldFail()
        {
            decimal result = calculator.Subtract(10m, 5m);

            Assert.IsFalse(result == 3m, $"Expected result to be different from 3, but got {result}");
        }
        [TestMethod]
        public void Subtract_WhenSameNumberIsSubtracted_ShouldReturnZero()
        {
            decimal number = 7.5m;

            decimal result = calculator.Subtract(number, number);

            // Assert result is zero with 7.5 - 7.5 = 0
            Assert.AreEqual(0m, result);
        }




    }
}