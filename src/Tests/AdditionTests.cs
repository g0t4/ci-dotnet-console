﻿namespace Tests
{
	using Calculator;
	using NUnit.Framework;

	[TestFixture]
	public class AdditionTests : AssertionHelper
	{
		[Test]
		public void AddPositiveNumbers()
		{
			var result = Program.add(1, 2);

			Expect(result, Is.EqualTo(3));
		}

		[Test]
		public void AddNegativeNumbers()
		{
			var result = Program.add(-1, -2);

			Expect(result, Is.EqualTo(-3));
		}

		[Test]
		public void AddPositiveAndNegativeNumbers()
		{
			var result = Program.add(1, -2);

			Expect(result, Is.EqualTo(-1));
		}
	}
}