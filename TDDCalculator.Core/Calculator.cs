using System;
using TDDCalculator.Core.Abstractions;

namespace TDDCalculator.Core
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {

        }

        public decimal Add(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Subtract(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Multiply(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }
    }

    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
            
        }
    }
}