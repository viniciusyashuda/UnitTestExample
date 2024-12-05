using Calculator.Services;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        private CalculatorService _calculatorService;

        public CalculatorTest()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void ShouldSum5And10AndReturn15()
        {
            //Arrange
            int number1 = 5;
            int number2 = 10;
            //Act
            int result = _calculatorService.Sum(number1, number2);
            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void ShouldVerifyIf4IsEvenAndReturnTrue()
        {
            //Arrange
            int number = 4;
            //Act
            bool result = _calculatorService.IsEven(number);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(new int[] {2, 4, 6, 8, 10})]
        public void ShouldVerifyIfNumbersAreEvenAndReturnTrue(int[] numbers)
        {
            //Act / Assert
            Assert.All(numbers, number => Assert.True(_calculatorService.IsEven(number)));
        }
    }
}