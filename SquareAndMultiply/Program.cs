using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SquareAndMultiply.Test")]
namespace SquareAndMultiply
{
	class Program
	{
		static void Main(string[] args)
		{
			long basis, exponent, modulo;
			if (args.Length != 3)
			{
				Console.Write("base: ");
				basis = Convert.ToInt64(Console.ReadLine());
				
				Console.Write("exponent: ");
				exponent = Convert.ToInt64(Console.ReadLine());
				
				Console.Write("modulo: ");
				modulo = Convert.ToInt64(Console.ReadLine());
			}
			else
			{
				basis = Convert.ToInt64(args[0]);
				exponent = Convert.ToInt64(args[1]);
				modulo = Convert.ToInt64(args[2]);
			}
			
			WriteHeaderToConsole($"calculating {basis}^{exponent} mod {modulo}");
			Console.WriteLine();

			var (result, stepByStep) = ModuloCalculator.Calculate(basis, exponent, modulo);
			
			Console.WriteLine(stepByStep);
			Console.WriteLine();
			WriteHeaderToConsole($"Result : {basis}^{exponent} mod {modulo} = {result}");
		}

		private static void WriteHeaderToConsole(string output)
		{
			output = $"| {output} |";
			var headerRow = new string('-', output.Length);
			
			Console.WriteLine(headerRow);
			Console.WriteLine(output);
			Console.WriteLine(headerRow);
		}
	}
}