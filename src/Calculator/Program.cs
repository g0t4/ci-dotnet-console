namespace Calculator
{
	using System;

	public class Program
	{
		private static void Main()
		{
			while (true)
			{
				Console.WriteLine("Please enter two numbers to add separated by a space, or exit to close");
				var input = Console.ReadLine();
				if (input.Trim() == "exit")
				{
					break;
				}
				var numbers = input.Split(' ');
				var result = add(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
				Console.WriteLine("{0} + {1} = {2}", numbers[0], numbers[1], result);
			}
		}

		// method name intentionally lower case for code inspections demo
		public static int add(int a, int b)
		{
			return a + b;
		}

		// method name intentionally lower case for code inspections demo
		public static int subtract(int a, int b)
		{
			return a - b;
		}
	}
}