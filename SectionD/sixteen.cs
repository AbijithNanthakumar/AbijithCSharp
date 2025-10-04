using System;

public delegate double MathOperation(double a, double b);

class Calculator
{
    public static double Add(double a,double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        MathOperation o;

        o = Calculator.Add;
        Console.WriteLine(o(10, 2));

        o = Calculator.Subtract;
        Console.WriteLine(o(10,2));

        o = Calculator.Multiply;
        Console.WriteLine(o(10, 2));

        o = Calculator.Divide;
        Console.WriteLine(o(10, 2));
    }
}