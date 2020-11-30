using System;
using System.Collections.Generic;
using System.Text;
using FakeItEasy;
using FluentAssertions;
using TDDCalculator.Core.Abstractions;
using Xunit;

namespace TDDCalculator.Core.UnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, -5, -1)]
        public void Add_ValidOperands_ExpectedResult(decimal operand1, decimal operand2, decimal expectedResult)
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Add(operand1, operand2);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, -5, 9)]
        public void Subtract_ValidOperands_ExpectedResult(decimal operand1, decimal operand2, decimal expectedResult)
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Subtract(operand1, operand2);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, -5, -20)]
        public void Multiply_ValidOperands_ExpectedResult(decimal operand1, decimal operand2, decimal expectedResult)
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Multiply(operand1, operand2);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(4, -5, -0.8)]
        public void Divide_ValidOperands_ExpectedResult(decimal operand1, decimal operand2, decimal expectedResult)
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var result = sut.Divide(operand1, operand2);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Divide_ZeroDivisor_CalculatorException()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = 0;
            var sut = new Calculator();

            // Act
            Action act = () => sut.Divide(operand1, operand2);

            // Assert
            act.Should().Throw<CalculatorException>()
                .And.Message.Should().Contain("division by zero");
        }
    }
}
