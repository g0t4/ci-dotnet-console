namespace Calculator
{
	using System;

	public class Program
	{
		private static void Main(string[] numbers)
		{
			if (numbers.Length != 2)
			{
				Console.WriteLine("Error: please input two numbers to add");
				Console.ReadKey();
				return;
			}
			var result = add(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
			Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], result);
		}

		public static int add(int a, int b)
		{
			return a + b;
		}
	}
}