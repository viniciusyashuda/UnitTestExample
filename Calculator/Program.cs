using Calculator.Services;

var calculator = new CalculatorService();
var num1 = 2;
var num2 = 3;

Console.WriteLine($"{num1} + {num2} = {calculator.Sum(num1,num2)}");
