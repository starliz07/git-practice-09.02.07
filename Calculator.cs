using System;

namespace CalculatorApp
{
    public class Calculator
    {
        // сложение
        public int Add(int a, int b)
        {
            return a + b;
        }

        // умножение
        public int Multiply(int a, int b) { return a * b; }

        // Деление
        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (double)a / b;
        }
    }
}