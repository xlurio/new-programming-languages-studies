﻿using CalculatorNS;

class Program
{
    public static void Main(string[] args) {
        string calculation = MakeCalculation();
        decimal result = MakeCalculator(calculation);
        Console.WriteLine("{0:D}", result);
    }

    private static string MakeCalculation() {
        Console.WriteLine("Write the desired calculation:");
        string calculation = Console.ReadLine();
        return calculation.Trim();
    }

    private static decimal MakeCalculator(string calculation) {
        Calculator calculator = new Calculator();
        return calculator.Calculate(calculation);
    }
}
