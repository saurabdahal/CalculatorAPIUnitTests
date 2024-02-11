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
        public void Subtract_WhenBothNumbersArePositive_ShouldReturnCorrectResult()
        {
            // Act
            decimal result = calculator.Subtract(5.5m, 3.5m);

            // Assert
            Assert.AreEqual(2m, result);
        }

        [TestMethod]
        public void Subtract_WhenBothNumbersAreNegative_ShouldReturnCorrectResult()
        {
            // Act
            decimal result = calculator.Subtract(-2.5m, -3.5m);

            // Assert
            Assert.AreEqual(1m, result);
        }

        [TestMethod]
        public void Subtract_WhenOneNumberIsZero_ShouldReturnOtherNumber()
        {
            // Act
            decimal result1 = calculator.Subtract(0m, 5.5m);
            decimal result2 = calculator.Subtract(-3.3m, 0m);

            // Assert
            Assert.AreEqual(-5.5m, result1);
            Assert.AreEqual(-3.3m, result2);
        }

        [TestMethod]
        public void Subtract_WhenOneNumberIsPositiveAndOneIsNegative_ShouldReturnCorrectResult()
        {
            // Act
            decimal result = calculator.Subtract(2.5m, -3.5m);

            // Assert
            Assert.AreEqual(6m, result);
        }

        [TestMethod]
        public void Subtract_WhenNumbersAreLarge_ShouldReturnCorrectResult()
        {
            // Act
            decimal result = calculator.Subtract(1000000000000000000.5m, 0.5m);

            // Assert
            Assert.AreEqual(1000000000000000000m, result);
        }

        /* from here we start the unit tests for the Multiply method */

        [TestMethod]
        public void Multiply_WhenBothNumbersArePositive_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal num1 = 2.5m;
            decimal num2 = 3.5m;

            // Act
            decimal result = calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(8.75m, result);
        }

        [TestMethod]
        public void Multiply_WhenBothNumbersAreNegative_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal num1 = -2.5m;
            decimal num2 = -3.5m;

            // Act
            decimal result = calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(8.75m, result);
        }

        [TestMethod]
        public void Multiply_WhenOneNumberIsZero_ShouldReturnZero()
        {
            // Arrange
            decimal num1 = 0m;
            decimal num2 = 5.5m;

            // Act
            decimal result1 = calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(0m, result1);
        }

        [TestMethod]
        public void Multiply_WhenOneNumberIsPositiveAndOneIsNegative_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal num1 = 2.5m;
            decimal num2 = -3.5m;

            // Act
            decimal result = calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(-8.75m, result);
        }

        [TestMethod]
        public void Multiply_WhenNumbersAreLarge_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal num1 = 1000000000000000000.5m;
            decimal num2 = 2m;

            // Act
            decimal result = calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(2000000000000000001m, result);
        }

        /* from here we start the unit tests for the Divide method */

        [TestMethod]
        public void Divide_WhenDividingByPositiveNumber_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal numerator = 10m;
            decimal denominator = 2m;

            // Act
            decimal result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(5m, result);
        }

        [TestMethod]
        public void Divide_WhenDividingByNegativeNumber_ShouldReturnCorrectResult()
        {
            // Arrange
            decimal numerator = 15m;
            decimal denominator = -3m;

            // Act
            decimal result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(-5m, result);
        }

        [TestMethod]
        public void Divide_WhenDividingByZero_ShouldThrowDivideByZeroException()
        {
            // Arrange
            decimal numerator = 8m;
            decimal denominator = 0m;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(numerator, denominator));
        }

        [TestMethod]
        public void Divide_WhenDividingZeroByAnyNumber_ShouldReturnZero()
        {
            // Arrange
            decimal numerator = 0m;
            decimal denominator = 7m;

            // Act
            decimal result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(0m, result);
        }

        [TestMethod]
        public void Divide_WhenDividingLargeNumberBySmallNumber_ShouldReturnVeryLargeResult()
        {
            // Arrange
            decimal numerator = 999999999999999999.9m;
            decimal denominator = 0.1m;

            // Act
            decimal result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(9999999999999999999m, result);
        }

    }
}