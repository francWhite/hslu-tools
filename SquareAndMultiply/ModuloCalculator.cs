using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareAndMultiply
{
	internal class ModuloCalculator
	{
		public static (long result, string stepByStep) Calculate(long basis, long exponent, long modulo)
		{
			var sb = new StringBuilder();
			
			var exponentInBinary = Convert.ToString(exponent, 2);
			sb.AppendLine($"exponent in binary: {exponentInBinary}");
			
			var operations = CreateOperationQueue(exponentInBinary, sb);

			sb.Append("calculation: ");
			sb.Append(basis);
			
			var x = basis;
			while (operations.Any())
			{
				var operation = operations.Dequeue();
				if (operation == Operation.Square)
				{
					x = x * x % modulo;
				}
				else
				{
					x = x * basis % modulo;
				}
				
				sb.Append($"--{OperationToString(operation)}-->{x}");
			}

			return (x, sb.ToString());
		}

		private static Queue<Operation> CreateOperationQueue(string exponentInBinary, StringBuilder sb)
		{
			var result = new Queue<Operation>();
			foreach (var n in exponentInBinary)
			{
				result.Enqueue(Operation.Square);

				if (n == '0')
				{
					continue;
				}
				
				result.Enqueue(Operation.Multiply);
			}

			result.Dequeue();
			result.Dequeue();

			sb.Append("operations: (QM)");
			foreach (var operation in result)
			{
				sb.Append($"{OperationToString(operation)}");
			}
			
			sb.AppendLine();
			return result;
		}

		private static string OperationToString(Operation operation)
		{
			return operation == Operation.Square ? "Q" : "M";
		}
	}
}