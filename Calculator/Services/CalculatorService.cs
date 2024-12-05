namespace Calculator.Services
{
    public class CalculatorService
    {
        public int Sum(int num1, int num2) =>
            num1 + num2;

        public bool IsEven(int num) =>
            num % 2 == 0;
    }
}