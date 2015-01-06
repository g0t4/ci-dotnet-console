namespace LongTests
{
	using System.Threading;
	using NUnit.Framework;

	[TestFixture]
	public class LongAdditionTests : AssertionHelper
	{
		[Test]
		public void RunThroughOneMillionIterations()
		{
			Thread.Sleep(5000);
		}
	}
}