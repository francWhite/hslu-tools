using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ErweiterterEuklidischerAlgorithmus.Test
{
	[TestClass]
	public class CalculatorTest
	{
		[TestMethod]
		[DataRow(963, 218, 1, -103, 455)]
		[DataRow(464640, 31, 1, 13, -194849)]
		[DataRow(108780, 19, 1, 4, -22901)]
		public void CalculateGgt(long a, long b, long expectedGgt, long expectedX, long expectedY)
		{
			var (ggt, x, y, steps) = Calculator.CalculateGgt(a, b);

			ggt.Should().Be(expectedGgt);
			x.Should().Be(expectedX);
			y.Should().Be(expectedY);
		}
	}
}