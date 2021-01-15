using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
// ReSharper disable PossibleInvalidOperationException

namespace ErweiterterEuklidischerAlgorithmus
{
	internal static class Calculator
	{
		public static (long ggt, long x, long y, IReadOnlyList<Step> steps) CalculateGgt(long n, long m)
		{
			if (m > n)
			{
				var temp = m;
				m = n;
				n = temp;
			}
			
			var steps = new List<Step>
			{
				new Step(n, null, 1, 0),
				new Step(m, n / m, 0, 1)
			};

			while (steps[^1].a > 1)
			{
				var last = steps[^1];
				var penultimate = steps[^2];
			
				var a = penultimate.a % last.a;
				var q = last.a / a;
				var u = penultimate.u - last.q * last.u;
				var v = penultimate.v - last.q * last.v;
			
				steps.Add(new Step(a, q, u.Value, v.Value));
			}

			var lastStep = steps[^1];
			lastStep.q = null;
			return (lastStep.a, lastStep.u, lastStep.v, steps);
		}
	}

	[SuppressMessage("ReSharper", "InconsistentNaming")]
	internal class Step
	{
		public Step(long a, long? q, long u, long v)
		{
			this.a = a;
			this.q = q;
			this.u = u;
			this.v = v;
		}

		public long a { get; }
		public long? q { get; set; }
		public long u { get; }
		public long v { get; }
	}
}