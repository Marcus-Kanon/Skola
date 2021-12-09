using FluentMiniRäknare;

var calculator = new Calculator();

var digit = calculator.Digit(5.5).Digit(1.1).Operator('+').Result();

Console.WriteLine(digit);
