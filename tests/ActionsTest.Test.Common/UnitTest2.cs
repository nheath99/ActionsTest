using ActionsTest.Common;
using Xunit;

namespace ActionsTest.Test.Common
{
	public class UnitTest2
	{
		[Fact]
		public void Test2()
		{
			// Arrange
			var int1 = 21;
			var int2 = 22;

			// Act
			var result = Class1.TestAdd(int1, int2);

			// Assert
			Assert.Equal(43, result);
		}
	}
}
