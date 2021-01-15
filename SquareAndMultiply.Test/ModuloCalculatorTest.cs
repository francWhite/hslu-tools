using System;
using System.Diagnostics;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareAndMultiply.Test
{
	[TestClass]
	public class ModuloCalculatorTest
	{
		[TestMethod]
		[DataRow(1803, 1291, 2047, 1478)]
		[DataRow(59509, 85879, 109493, 25959)]
		[DataRow(59509, 269791, 466007, 291413)]
		public void Calculate_WithDataRows(long basis, long exponent, long modulo, long expectedResult)
		{
			var (result, stepByStep) = ModuloCalculator.Calculate(basis, exponent, modulo);
			Debug.WriteLine(stepByStep);
			
			result.Should().Be(expectedResult);
		}
	}
}