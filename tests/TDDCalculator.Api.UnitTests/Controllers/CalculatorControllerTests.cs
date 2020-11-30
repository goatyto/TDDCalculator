using System;
using System.Collections.Generic;
using System.Text;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using TDDCalculator.Api.Controllers;
using TDDCalculator.Core;
using TDDCalculator.Core.Abstractions;
using Xunit;

namespace TDDCalculator.Api.UnitTests.Controllers
{
    public class CalculatorControllerTests
    {
        private readonly ICalculator _calculator;

        public CalculatorControllerTests()
        {
            _calculator = A.Fake<ICalculator>();
        }

        [Fact]
        public void Add_ValidOperands_OkObjectResult()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = A.Dummy<decimal>();
            var sut = new CalculatorController(_calculator);

            // Act
            var response = sut.Add(operand1, operand2);

            // Assert
            response.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Subtract_ValidOperands_OkObjectResult()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = A.Dummy<decimal>();
            var sut = new CalculatorController(_calculator);

            // Act
            var response = sut.Subtract(operand1, operand2);

            // Assert
            response.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Multiply_ValidOperands_OkObjectResult()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = A.Dummy<decimal>();
            var sut = new CalculatorController(_calculator);

            // Act
            var response = sut.Multiply(operand1, operand2);

            // Assert
            response.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Divide_ValidOperands_OkObjectResult()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = A.Dummy<decimal>();
            var sut = new CalculatorController(_calculator);

            // Act
            var response = sut.Divide(operand1, operand2);

            // Assert
            response.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public void Divide_ZeroSecondOperand_BadRequestObjectResult()
        {
            // Arrange
            var operand1 = A.Dummy<decimal>();
            var operand2 = A.Dummy<decimal>();
            var sut = new CalculatorController(_calculator);

            var exceptionMessage = "This is a test exception.";
            A.CallTo(() => _calculator.Divide(A<decimal>.Ignored, A<decimal>.Ignored))
                .Throws(() => new CalculatorException(exceptionMessage));

            // Act
            var response = sut.Divide(operand1, operand2);

            // Assert
            response.Should()
                .BeOfType<BadRequestObjectResult>();
        }
    }
}
