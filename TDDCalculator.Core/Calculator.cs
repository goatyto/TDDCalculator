using System;
using TDDCalculator.Core.Abstractions;

namespace TDDCalculator.Core
{
    public class Calculator : ICalculator
    {
        private readonly OperandValidator _operandValidator;

        public Calculator()
        {
            _operandValidator = new OperandValidator();
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (!_operandValidator.ValidateDivisor(b))
            {
                throw new CalculatorException("Invalid operation - division by zero!");
            }

            return a / b;
        }
    }

    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
            
        }
    }
}