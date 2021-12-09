using FluentMiniRäknare;

var calculator = new Calculator();

var digit = calculator.Digit(5.5).Operator('+').Digit(1.1).Operator('-').Digit(6.5).Result();

Console.WriteLine(digit);
