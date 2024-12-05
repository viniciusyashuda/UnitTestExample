using Calculator.Services;

namespace CalculatorTest
{
    public class StringValidatorTest
    {
        private StringValidatorService _stringValidatorService;

        public StringValidatorTest()
        {
            _stringValidatorService = new StringValidatorService();
        }

        [Fact]
        public void ShouldCountCharactersInHelloAndReturn5()
        {
            //Arrange
            string text = "Hello";
            //Act
            int result = _stringValidatorService.CountCharacters(text);
            //Assert
            Assert.Equal(5, result);
        }
    }
}