using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ErweiterterEuklidischerAlgorithmus.Test")]

namespace ErweiterterEuklidischerAlgorithmus
{
	class Program
	{
		static void Main(string[] args)
		{
			long n, m;
			if (args.Length != 2)
			{
				Console.Write("n: ");
				n = Convert.ToInt64(Console.ReadLine());

				Console.Write("m: ");
				m = Convert.ToInt64(Console.ReadLine());
			}
			else
			{
				n = Convert.ToInt64(args[0]);
				m = Convert.ToInt64(args[1]);
			}

			WriteHeaderToConsole($"Calculating ggT({n}, {m} with extended euclidean algorithm");
			var (ggt, x, y, steps) = Calculator.CalculateGgt(n, m);
			
			WriteSteps(steps);
			
			WriteHeaderToConsole($"ggT = {ggt}, x = {x}, y = {y} => {ggt} = {x} * {n} + {y} * {m}");
		}

		private static void WriteHeaderToConsole(string output)
		{
			output = $"| {output} |";
			var headerRow = new string('-', output.Length);

			Console.WriteLine(headerRow);
			Console.WriteLine(output);
			Console.WriteLine(headerRow);
		}

		private static void WriteSteps(IReadOnlyList<Step> steps)
		{
			var maxLengthA = steps.Max(step => step.a.ToString().Length);
			var maxLengthQ = steps.Max(step => step.q.ToString().Length);
			var maxLengthU = steps.Max(step => step.u.ToString().Length);
			var maxLengthV = steps.Max(step => step.v.ToString().Length);

			foreach (var step in steps)
			{
				Console.Write($"{step.a.ToString().PadLeft(maxLengthA)}  ");
				Console.Write($"{step.q?.ToString().PadLeft(maxLengthQ) ?? "-"}  ");
				Console.Write($"{step.u.ToString().PadLeft(maxLengthU)}  ");
				Console.Write($"{step.v.ToString().PadLeft(maxLengthV)}  ");
				Console.WriteLine();
			}
		}
	}
}