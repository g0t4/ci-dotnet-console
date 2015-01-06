namespace Tests
{
	using Calculator;
	using NUnit.Framework;

	[TestFixture]
	public class SubtractionTests : AssertionHelper
	{
		[Test]
		public void SubtractPositiveNumbers()
		{
			var result = Program.subtract(1, 2);

			Expect(result, Is.EqualTo(-1));
		}

		[Test]
		public void SubtractNegativeNumbers()
		{
			var result = Program.subtract(-1, -2);

			Expect(result, Is.EqualTo(1));
		}

		[Test]
		public void SubtractPositiveThenNegativeNumber()
		{
			var result = Program.subtract(1, -2);

			Expect(result, Is.EqualTo(3));
		}

		[Test]
		public void SubtractNegativeThenPositiveNumber()
		{
			var result = Program.subtract(-1, 2);

			Expect(result, Is.EqualTo(-3));
		}
	}
}